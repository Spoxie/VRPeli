using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button NewGameButton;
    public Button HighScoreButton;
    public Button InfoButton;
    public string NewGameScene;
    public GameObject Info;
    public GameObject HighScorea;
    





    public void NewGame()
    {
        SceneManager.LoadScene("TESTISCENE");
    }
    public void HighScore()
    {
        

    }
    
    
    public void OpenInfo()
    {
        Info.SetActive(true);
    }
    public void OpenHighScore()
    {
        HighScorea.SetActive(true);
    }



}
