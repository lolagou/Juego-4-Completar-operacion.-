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

    public Vector3 PosicionObjeto1;
    public Vector3 PosicionObjeto2;
    public Vector3 PosicionObjeto3;
    public Vector3 PosicionObjeto4;

    public int precioObjeto1;
    public int precioObjeto2;
    public int precioObjeto3;
    public int precioObjeto4;

    public Text txtPrecioObjeto1;
    public Text txtPrecioObjeto2;
    public Text txtPrecioObjeto3;
    public Text txtPrecioObjeto4;

    public GameObject Objeto1;
    public GameObject Objeto2;
    public GameObject Objeto3;
    public GameObject Objeto4;


    private int Random_Number;
    // Start is called before the first frame update
    void Start()
    {
        Random_Number = Random.Range(0, objetos.Length);
        Objeto1 = objetos[Random_Number];
        Instantiate(Objeto1, PosicionObjeto1, objetos[Random_Number].transform.rotation);

        Random_Number = Random.Range(0, objetos.Length);
        Objeto2 = objetos[Random_Number];
        Instantiate(Objeto2, PosicionObjeto2, objetos[Random_Number].transform.rotation);

        Random_Number = Random.Range(0, objetos.Length);
        Objeto3 = objetos[Random_Number];
        Instantiate(Objeto3, PosicionObjeto3, objetos[Random_Number].transform.rotation);

        Random_Number = Random.Range(0, objetos.Length);
        Objeto4 = objetos[Random_Number];
        Instantiate(Objeto4, PosicionObjeto4, objetos[Random_Number].transform.rotation);

        precioObjeto1 = Objeto1.GetComponent<ClickOnObjects>().valor;
        precioObjeto2 = Objeto2.GetComponent<ClickOnObjects>().valor;
        precioObjeto3 = Objeto3.GetComponent<ClickOnObjects>().valor;
        precioObjeto4 = Objeto4.GetComponent<ClickOnObjects>().valor;

        txtPrecioObjeto1.text = "$ " + precioObjeto1;
        txtPrecioObjeto2.text = "$ " + precioObjeto2;
        txtPrecioObjeto3.text = "$ " + precioObjeto3;
        txtPrecioObjeto4.text = "$ " + precioObjeto4;



    }

    public void Valor_del_Objeto(GameObject Objeto)
    { 
        
    }
        
    // Update is called once per frame
    void Update()
    {

    }

    void RandomizePositions()
    {
         
    }
}
