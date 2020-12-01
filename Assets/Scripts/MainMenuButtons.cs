using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public int ranNum;
    
    public void StartTheGame() 
    {
        ranNum = Random.Range(2, 7);
        SceneManager.LoadScene(ranNum, LoadSceneMode.Single);
        PlayerScore.scoreInGame = 0;
    }
    public void doExitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu() 
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
