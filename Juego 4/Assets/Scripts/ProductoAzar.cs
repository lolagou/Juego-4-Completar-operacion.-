using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductoAzar : MonoBehaviour
{
    public Text[] optionsText;
    public GameObject[] objetos;
    public float randomnumber;
    public GameObject prueba; 
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prueba, new Vector3(2.23f, -0.61f, -3.07f), Quaternion.identity);
    }
        
    // Update is called once per frame
    void Update()
    {

    }

    void RandomizePositions()
    {
         
    }
}
