using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class two_buttonCaptions : MonoBehaviour
{
    string[] colors = {"red", "blue", "green", "white", "black", "bordeaux", "purple", "green", "pink", "brown", "orange", "yellow", "gray", "aqua", "cyan", "light blue", "lime", "dark green", "beige", "navy", "scarlet", "rust", "sky blue", "peach" };
    public Text button1Text;
    public Text button2Text;
    public Text button3Text;
    

    void Start()
    {
        int one = Random.Range(0, colors.Length);
        int two = Random.Range(0, colors.Length);
        int three = Random.Range(0, colors.Length);
        button1Text.text = colors[one];
        button2Text.text = colors[two];
        button3Text.text = colors[three];
        if (one == two) 
        {
            button1Text.text = colors[one];
            button2Text.text = colors[two];
            button3Text.text = colors[three];
        }
        if (one == three)
        {
            button1Text.text = colors[one];
            button2Text.text = colors[two];
            button3Text.text = colors[three];
        }
        if (two == one)
        {
            button1Text.text = colors[one];
            button2Text.text = colors[two];
            button3Text.text = colors[three];
        }
        if (two == three)
        {
            button1Text.text = colors[one];
            button2Text.text = colors[two];
            button3Text.text = colors[three];
        }
        if (three == one)
        {
            button1Text.text = colors[one];
            button2Text.text = colors[two];
            button3Text.text = colors[three];
        }
        if (three == two)
        {
            button1Text.text = colors[one];
            button2Text.text = colors[two];
            button3Text.text = colors[three];
        }

    }

    

    
}
