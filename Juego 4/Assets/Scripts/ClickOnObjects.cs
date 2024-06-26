﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnObjects : MonoBehaviour
{
    public Text text;
    int n = 0; 

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (n == 0)
        {
            text.fontStyle = FontStyle.Bold;
            text.color = Color.blue;
            n++; 
        }
        else if (n == 1)
        {
            text.fontStyle = FontStyle.Normal;
            text.color = Color.black;
            n = 0; 
        }
    }

}
