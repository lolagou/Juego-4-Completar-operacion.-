using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResponderScript : MonoBehaviour
{
    public Button ResponderBtn;



    public GameObject panelNotificaciones;
    public GameObject panelError;
    public GameObject panelRespuesta;
    public Text Btn_jugarOtraVez;
    public Text textNotificaciones;
    public Text Btn_MasJuegos;

    public Text[] optionsText;
    public GameObject[] objetos;
    public GameObject prueba;

    public GameObject Objeto3;
    public GameObject Objeto4;

    public int Selected = -1;
    public int Ecuacion;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonResponderClick()
    {
        if (Selected == -1)
        {
            panelError.SetActive(true);
            panelRespuesta.SetActive(false);
        }
        else if (valorTotal.text == valor1.text + objetos[Selected].GetComponent<ClickOnObjects>().valor)
        {
            panelNotificaciones.SetActive(true);
            panelRespuesta.SetActive(false);
            textNotificaciones.text = "El resultado es correcto";
            Btn_jugarOtraVez.text = "REINICIAR DESAFIO";
            Btn_MasJuegos.text = "Mas Juegos";
        }
        else
        {
            panelNotificaciones.SetActive(true);
            panelRespuesta.SetActive(false);
            textNotificaciones.text = "El resultado es incorrecto";
            Btn_jugarOtraVez.text = "JUGAR OTRA VEZ";
            Btn_MasJuegos.text = "Mas Juegos";
        }
    }

    public void Salir()
    {
         SceneManager.LoadScene("Seleccionar Mas Juegos");
    }
}
