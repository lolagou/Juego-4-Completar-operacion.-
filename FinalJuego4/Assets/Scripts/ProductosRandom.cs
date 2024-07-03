using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductosRandom : MonoBehaviour
{

    // Declaracion de posiciones

    public GameObject[] Productos;
    Vector3 pos0 = new Vector3(-1.75f, 2.28f, -5.71f);
    Vector3 pos1 = new Vector3(-2, 1, -6.5f);
    Vector3 pos2 = new Vector3(0, 1, -6.5f);
    Vector3 pos3 = new Vector3(1.7f, 1, -6.5f);

    // -------------------------------------------------//

    // Declaracion Textos

    public Text precio0;
    public Text precio1;
    public Text precio2;
    public Text precio3;
    public Text TextoprecioTotal; 

    // -----------------------------------------------//

    // Precios randoms

    public int precioTotal;
    int precioN;
    public int precioCorrecto;
    int precioRestante1;
    int precioRestante2; 
    // Start is called before the first frame update
    public void Start()
    {
        RandomSpawn(pos0);
        RandomSpawn(pos1);
        RandomSpawn(pos2);
        RandomSpawn(pos3);

        precioTotal = Random.Range(20, 40);
        precioN = Random.Range(0, 19);
        precioCorrecto = precioTotal - precioN;
        precioRestante1 = Random.Range(0, 20);
        precioRestante2 = Random.Range(0, 20);

        TextoprecioTotal.text = "+   ?   =   $" + precioTotal.ToString();
        precio0.text = "$"+precioN.ToString();
        precio1.text = "$"+precioCorrecto.ToString();
        precio2.text = "$"+precioRestante1.ToString();
        precio3.text = "$"+precioRestante2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomSpawn(Vector3 position)
    {
        int random = Random.Range(0, Productos.Length);
        Productos[random].SetActive(true);
        Instantiate(Productos[random], position, Productos[random].transform.rotation);
        Productos[random].SetActive(false);
    }
}
