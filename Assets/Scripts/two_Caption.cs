using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class two_Caption : MonoBehaviour
{
    string[] names = { "Karen", "Gosho", "Jennie", "Silva", "George", "Clay", "Joy", "Maddison", "Igor", "Dan", "Abigail", "Yoan", "Emma", "Grace", "Patrick" };

    public Text captionYeet;
    void Start()
    {
        var lengthOfNames = names.Length;
        int index = Random.Range(0, 16);
        captionYeet.text = $"What is {names[index]}'s favorite color?";
    }
}
