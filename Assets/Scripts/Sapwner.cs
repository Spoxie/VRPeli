using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapwner : MonoBehaviour
{
    public GameObject[] vastustajat;
    public Vector3 spawnValues;
    public float spawnwait;
    public float spawnleastwait;
    public float spawnmostwait;
    public float spawnerase;
    public int startwait;
    // Start is called before the first frame update

    int randVastustaja;
    void Start()
    {
        StartCoroutine(waitspawner()); 
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnwait = Random.Range(spawnleastwait, spawnmostwait);
        
        
    }
    IEnumerator waitspawner()
    {
        yield return new WaitForSeconds(startwait);

        while (true)
        {
            randVastustaja = Random.Range(0, 2);
            Vector3 spawnposition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(vastustajat[randVastustaja], spawnposition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnwait);
        }
    }
}
