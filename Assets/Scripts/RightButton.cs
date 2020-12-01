using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RightButton : MonoBehaviour
{
    
    public void RightButtonClick() 
    {
        PlayerScore.scoreInGame++;
        var index = Random.Range(2, 7);
        SceneManager.LoadScene(index, LoadSceneMode.Single); 
    
    }

    public void WrongButtonClick() 
    {
        SceneManager.LoadScene("SceneOfLoss", LoadSceneMode.Single);
    }
}
