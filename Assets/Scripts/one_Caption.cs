
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class one_Caption : MonoBehaviour
{
    string[] names = { "Karen", "Bojilka", "Maddy", "Tracy", "Megan", "Jack", "Joy", "Irene", "Ivan", "Lisa", "Jisoo", "Ricky", "Evan", "Emily", "Shawn" };
    
    public Text captionYeet;
    void Start()
    {
        
        int index = Random.Range(0, names.Length);
        captionYeet.text = $"What {names[index]} chose from 1 to 3?";
    }

    
}
