using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProductoAzar : MonoBehaviour
{
    [System.Serializable]
    public class ObjetoConValor
    {
        public GameObject objeto;
        public int valor;
    }

    public ObjetoConValor[] Objetos;
    public Text valor1;
    public Text valorTotal;
    public Text Articulo1;
    public Text Articulo2;
    public Text Articulo3;
    public Text[] valoresPosibles;
    public int dinerototal;
    public int indiceCorrecto;

    // Start is called before the first frame update
    void Start()
    {
        int dinero1 = Random.Range(0, 20);
        int Objeto1 = Random.Range(0, 4);
        Objetos[Objeto1].valor = dinero1;
        valor1.text = "$" + dinero1.ToString();

        dinerototal = Random.Range(dinero1, dinero1 + 20);
        valorTotal.text = "$" + dinerototal.ToString();

        int dinero2 = dinerototal - dinero1;
        int Objeto2;
        if (dinero2 == dinero1)
        {
            Objeto2 = Objeto1;
        }
        else
        {
            do
            {
                Objeto2 = Random.Range(0, 4);
            } while (Objeto1 == Objeto2);
        }
        Objetos[Objeto2].valor = dinero2;

        int Objeto3 = Random.Range(0, 4);
        if (Objeto3 != Objeto2 && Objeto3 != Objeto1)
        {
            do
            {
                Objetos[Objeto3].valor = Random.Range(0, 20);
            } while (Objetos[Objeto3].valor == Objetos[Objeto2].valor || Objetos[Objeto3].valor == Objetos[Objeto1].valor);
        }

        int Objeto4 = Random.Range(0, 4);
        if (Objeto4 != Objeto3 && Objeto4 != Objeto2 && Objeto4 != Objeto1)
        {
            do
            {
                Objetos[Objeto4].valor = Random.Range(0, 20);
            } while (Objetos[Objeto4].valor == Objetos[Objeto3].valor || Objetos[Objeto4].valor == Objetos[Objeto2].valor || Objetos[Objeto4].valor == Objetos[Objeto1].valor);
        }
        indiceCorrecto = Random.Range(0, 3);
        valoresPosibles[indiceCorrecto].text = "$" + Objetos[Objeto2].valor.ToString();

        List<int> IndiceObjetos = new List<int> {0, 1, 2};
        IndiceObjetos.Remove(indiceCorrecto);
        valoresPosibles[IndiceObjetos[0]].text = "$" + Objetos[Objeto3].valor.ToString();
        valoresPosibles[IndiceObjetos[1]].text = "$" + Objetos[Objeto4].valor.ToString();

        Instantiate(Objetos[Objeto1].objeto, new Vector3(-5f, 5.13f, 0.68f), Objetos[Objeto1].objeto.transform.rotation);
        Instantiate(Objetos[Objeto2].objeto, new Vector3(-3f, 0.47f, -3f), Objetos[Objeto2].objeto.transform.rotation);
        Instantiate(Objetos[Objeto3].objeto, new Vector3(2.03f, 0.47f, -3f), Objetos[Objeto3].objeto.transform.rotation);
        Instantiate(Objetos[Objeto4].objeto, new Vector3(6f, 0.47f, -3f), Objetos[Objeto4].objeto.transform.rotation);
    }
        
    // Update is called once per frame
    void Update()
    {

    }
    
}
