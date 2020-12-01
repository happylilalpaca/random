using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{

    static public int scoreInGame;
    public Text scoreText;
   
    void Start()
    {
        
        scoreText.text = $"Score: {scoreInGame}";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
