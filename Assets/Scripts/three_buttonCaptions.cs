using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class three_buttonCaptions : MonoBehaviour
{
    string[] characters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    public Text button1Text;
    public Text button2Text;
    public Text button3Text;

    void Start()
    {
        int one = Random.Range(0, characters.Length);
        int two = Random.Range(0, characters.Length);
        int three = Random.Range(0, characters.Length);
        button1Text.text = characters[one];
        button2Text.text = characters[two];
        button3Text.text = characters[three];
        if (one == two || one == three || two == three)
        {
            button1Text.text = characters[one];
            button2Text.text = characters[two];
            button3Text.text = characters[three];
            if (one == two || one == three || two == three)
            {
                button1Text.text = characters[one];
                button2Text.text = characters[two];
                button3Text.text = characters[three];
                if (one == two || one == three || two == three)
                {
                    button1Text.text = characters[one];
                    button2Text.text = characters[two];
                    button3Text.text = characters[three];
                }
            }
        }
    }
}
