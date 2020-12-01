using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class five_Caption : MonoBehaviour
{
    string[] firstName = { "Tommy", "Shrek", "Chester", "Liam", "Jacob", "Michael", "Leo", "Linda", "Shaquelle", "Maria", "Joseph", "Marty", "Lucifer" };
    string[] secondName = { "Jesus", "Asher", "Chris", "Christinna", "Dylan", "Elias", "Cammeron", "Caleb", "Emily", "Anna", "Victoria", "Rebecca", "Heather" };
    public Text caption;
    public Text button1Text;
    public Text button2Text;

    void Start()
    {
        int index1 = Random.Range(0, firstName.Length);
        int index2 = Random.Range(0, secondName.Length);
        string firstNamePicked = firstName[index1];
        string secondNamePicked = secondName[index2];
        button1Text.text = firstNamePicked;
        button2Text.text = secondNamePicked;
        caption.text = $"Who is richer? \n{firstNamePicked} or {secondNamePicked}?";
    }

    
}
