using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnObjects : MonoBehaviour
{
    public Text[] Textos;
    public int valor = 0;
    int n = 0;
    int n2 = 0;
    int n3 = 0;

    void Start()
    {

    }


    void Update()
    {

    }

    void OnMouseDown()
    {
        if (transform.position == new Vector3 (-3f, 0.47f, -3f))
        {
            if (n == 0)
            {
                Textos[0].fontStyle = FontStyle.Bold;
                Textos[0].color = Color.blue;
                n++;
            }
            else if (n == 1)
            {
                Textos[0].fontStyle = FontStyle.Normal;
                Textos[0].color = Color.black;
                n = 0;
            }
        }
        else if (transform.position == new Vector3(2.03f, 0.47f, -3f))
        {
            if (n2 == 0)
            {
                Textos[1].fontStyle = FontStyle.Bold;
                Textos[1].color = Color.blue;
                n2++;
            }
            else if (n2 == 1)
            {
                Textos[1].fontStyle = FontStyle.Normal;
                Textos[1].color = Color.black;
                n2 = 0;
            }
        }
        else if (transform.position == new Vector3(6f, 0.47f, -3f))
        {
            if (n3 == 0)
            {
                Textos[2].fontStyle = FontStyle.Bold;
                Textos[2].color = Color.blue;
                n3++;
            }
            else if (n3 == 1)
            {
                Textos[2].fontStyle = FontStyle.Normal;
                Textos[2].color = Color.black;
                n3 = 0;
            }
        }
    }
}
