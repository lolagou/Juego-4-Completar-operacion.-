using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProductoAzar : MonoBehaviour
{
    //public Button ResponderBtn;
    //public GameObject panelNotificaciones;
    //public GameObject panelError;
    //public GameObject panelRespuesta;
    //public Text Btn_jugarOtraVez;
    //public Text textNotificaciones;
    //public Text Btn_MasJuegos;
    //public int Selected = -1;
    //public int Ecuacion;

    public GameObject[] Objetos;
    public Text valor1;
    public Text valorTotal;
    public Text Articulo1;
    public Text Articulo2;
    public Text Articulo3;
    public Text[] valoresPosibles;

    // Start is called before the first frame update
    void Start()
    {
        int dinero1 = Random.Range(0, 20);
        int dinerototal = Random.Range(dinero1 + 1, dinero1 + 20);
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
    public void ButtonResponderClick()
    {
       // if (Selected == -1)
       // {
       //     panelError.SetActive(true);
       //     panelRespuesta.SetActive(false);
       // }
      //  else if (Ecuacion == precioObjeto1 + objetos[Selected].GetComponent<ClickOnObjects>().valor)
      //  {
       //     panelNotificaciones.SetActive(true);
       //     panelRespuesta.SetActive(false);
       //     textNotificaciones.text = "El resultado es correcto";
       //     Btn_jugarOtraVez.text = "REINICIAR DESAFIO";
      //      Btn_MasJuegos.text = "Mas Juegos";
     //   }
     //   else
     //   {
     //       panelNotificaciones.SetActive(true);
      //      panelRespuesta.SetActive(false);
       //     textNotificaciones.text = "El resultado es incorrecto";
       //     Btn_jugarOtraVez.text = "JUGAR OTRA VEZ";
       //     Btn_MasJuegos.text = "Mas Juegos";
      //  }
    }

    public void Salir()
    {
       // SceneManager.LoadScene("Seleccionar Mas Juegos");
    }
}
