using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductoAzar : MonoBehaviour
{
    public Text[] optionsText;
    public GameObject[] objetos;
    public GameObject prueba;
    public float randomnumber;
    public int[] arrayPrecios;


    public Vector3 PosicionEquation;
    public Vector3 PosicionObjeto1;
    public Vector3 PosicionObjeto2;
    public Vector3 PosicionObjeto3;
    public Vector3 PosicionObjeto4;

    //Vector3 coordenadasArriba = new Vector3(-279f, 125f, 0f);
    //Vector3 coordenadasDerecha = new Vector3(-260f, -133f, 0f);
    //Vector3 coordenadasMedio = new Vector3(12f, -133f, 0f);
    //Vector3 coordenadasIzquierda = new Vector3(262f, -133f, 0f);

    public int precioObjeto1;
    public int precioObjeto2;
    public int precioObjeto3;
    public int precioObjeto4;
    public int precioEquation;
    public int Total; 

    public Text txtPrecioObjeto1;
    public Text txtPrecioObjeto2;
    public Text txtPrecioObjeto3;
    public Text txtPrecioObjeto4;
    public Text EquationText;

    public GameObject ObjetoEquation; 
    public GameObject Objeto1;
    public GameObject Objeto2;
    public GameObject Objeto3;
    public GameObject Objeto4;


    private int Random_Number;
    // Start is called before the first frame update
    void Start()
    {
        //Se crea una funcion RandomNumer donde se establece con un RandomRange la longuitud que pueden abarcar los elementos del array gameobject que es objetos
        //Va desde el cero hasta la longuitud de los elementos por ello se utliza .lenght
        //A cada objeto se lo iguala a la array con randomnumer
        //Luego se utiliza un Instantiate el cual consta de tres partes (_enemyObject, new Vector2(0,8), Quaternion).  
        //En el primero se pone el objeto, luego el vector que en este caso es la posicion y por ultimo la rotacion del objeto que se tuvo a transformar. 
   
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

        //El precio del Objeto1 y se obtiene el component cuando se clickee en el objeto indicado y se le da un valor. 

        precioObjeto1 = Objeto1.GetComponent<ClickOnObjects>().valor;
        precioObjeto2 = Objeto2.GetComponent<ClickOnObjects>().valor;
        precioObjeto3 = Objeto3.GetComponent<ClickOnObjects>().valor;
        precioObjeto4 = Objeto4.GetComponent<ClickOnObjects>().valor;
        precioEquation = ObjetoEquation.GetComponent<ClickOnObjects>().valor;

        //El texto de cada objeto tiene ser igual al precio asignado a cada objeto. 

        txtPrecioObjeto1.text = "$ " + precioObjeto1;
        txtPrecioObjeto2.text = "$ " + precioObjeto2;
        txtPrecioObjeto3.text = "$ " + precioObjeto3;
        txtPrecioObjeto4.text = "$ " + precioObjeto4;
        EquationText.text = "$ " + precioEquation;

        //Se crea un array de los precios, donde se indican todos los que hay en los corchetes. Luego se genera un RandomRange
        //Y se hace el calculo que el precioTotal tiene que ser igual al equiation text mas alguno del array de los precios. 

        int[] arrayPrecios = { precioObjeto1, precioObjeto2, precioObjeto3, precioObjeto4 };
        int precioAzar = Random.Range(0, arrayPrecios.Length);
        int precioTotal = precioEquation + arrayPrecios[precioAzar];

        txtPrecioObjeto1.text = ("$" + precioTotal);
        Total = precioTotal;



    }

    void RandomNumer()
    {

        int azar = Random.Range(0, objetos.Length);
        Objeto1 = objetos[azar];
        Objeto1.SetActive(true);
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
