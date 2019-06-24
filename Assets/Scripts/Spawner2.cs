using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour

{
    public Vector3 center;
    public Vector3 size;
    
    public GameObject[] vastustajat;
    public Vector3 spawnValues;
    public float spawnwait;
    public float spawnleastwait;
    public float spawnmostwait;
    public int startwait;
    int randVastustaja;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(waitspawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnwait = Random.Range(spawnleastwait, spawnmostwait);
    }
    
        
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 5f);
        Gizmos.DrawCube(center, size);
    }
    IEnumerator waitspawner()
    {
        yield return new WaitForSeconds(startwait);

        while (true)
        {
            randVastustaja = Random.Range(0, 2);
            Vector3 spawnposition = new Vector3(Random.Range(-size.x, spawnValues.x), 1, Random.Range(-size.z, size.z));
            Instantiate(vastustajat[randVastustaja], spawnposition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            
            yield return new WaitForSeconds(spawnwait);
        }
    }
}