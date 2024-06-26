﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProductoAzar : MonoBehaviour
{

    public GameObject[] Objetos;
    public Text valor1;
    public Text valorTotal;
    public Text Articulo1;
    public Text Articulo2;
    public Text Articulo3;
    public Text[] valoresPosibles;

    public Text[] optionsText;
    public GameObject[] objetos;
    public GameObject prueba;

    public GameObject Objeto3;
    public GameObject Objeto4;

    public int Ecuacion;

    private int Random_Number;

    // Start is called before the first frame update
    void Start()
    {
        int dinero1 = Random.Range(0, 20);
        int dinerototal = Random.Range(dinero1, dinero1 + 20);
        int dinero2 = dinerototal - dinero1;
        valor1.text = "$" + dinero1.ToString();
        valorTotal.text = "$" + dinerototal.ToString();
        int indiceCorrecto = Random.Range(0, 2);
        for (int i = 0;  i < valoresPosibles.Length; i++)
        {
            if (i == indiceCorrecto)
            {
                valoresPosibles[indiceCorrecto].text = "$" + dinero2.ToString();
            }
            else
            {
                int random;
                do
                {
                    random = Random.Range(0, 20);
                } while (random == dinero2);
                valoresPosibles[i].text = "$" + random.ToString();
            }
        }

        int random1 = Random.Range(0, 4);
        int random2 = Random.Range(0, 4);
        int random3 = Random.Range(0, 4);
        int random4 = Random.Range(0, 4);

        Instantiate(Objetos[random1], new Vector3(-5f, 5.13f, 0.68f), Objetos[random1].transform.rotation);
        Instantiate(Objetos[random2], new Vector3(-3f, 0.47f, -3f), Objetos[random2].transform.rotation);
        Instantiate(Objetos[random3], new Vector3(2.03f, 0.47f, -3f), Objetos[random3].transform.rotation);
        Instantiate(Objetos[random4], new Vector3(6f, 0.47f, -3f), Objetos[random4].transform.rotation);
    }
        
    // Update is called once per frame
    void Update()
    {

    }
    
}
