using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChangeColorOnClick : MonoBehaviour
{
    // Declaramos Textos y posibles posiciones 

    public Text[] optionsText; 
    int n1 = 0;
    int n2 = 0;
    int n3 = 0; 

    // --------------------------------------//


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (transform.position.x == -2)
        {
            if (n1 == 0)
            {
                optionsText[0].color = Color.blue;
                optionsText[0].fontStyle = FontStyle.Bold;
                n1++;
            }
            else if (n1 == 1)
            {
                optionsText[0].color = Color.black;
                optionsText[0].fontStyle = FontStyle.Normal;
                n1--;
            }
        }
        else if (transform.position.x == 0)
        {
            if (n2 == 0)
            {
                optionsText[1].color = Color.blue;
                optionsText[1].fontStyle = FontStyle.Bold;
                n2++;
            }
            else if (n2 == 1)
            {
                optionsText[1].color = Color.black;
                optionsText[1].fontStyle = FontStyle.Normal;
                n2--;
            }
        }
        else if (transform.position.x == 1.7f)
        {
            if (n3 == 0)
            {
                optionsText[2].color = Color.blue;
                optionsText[2].fontStyle = FontStyle.Bold;
                n3++;
            }
            else if (n3 == 1)
            {
                optionsText[2].color = Color.black;
                optionsText[2].fontStyle = FontStyle.Normal;
                n3--;
            }
        }
    }
    
}
