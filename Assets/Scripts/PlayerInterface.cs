﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    static public int scoreInGame;
    public Text scoreText;
   
    void Start()
    {
        
        scoreText.text = $"Score: {scoreInGame}";
        
    }

 
}
