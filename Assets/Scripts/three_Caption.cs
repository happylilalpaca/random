using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class three_Caption : MonoBehaviour
{
    public Text caption;
    string[] capToChooseFrom = {"Just pick one character.", "Oh, are these... part of the alphabet? Click one.", "Just choose something.", "Whatever you like.", "Your luck, your choice.", "Random characters. Nice. Pick one." };
    void Start()
    {
        int index = Random.Range(0, capToChooseFrom.Length);
        caption.text = capToChooseFrom[index];
    }

    
}
