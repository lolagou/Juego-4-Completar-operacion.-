using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResponderScript : MonoBehaviour
{
    public GameObject ResponderBtn;
    
    public GameObject panelNotificaciones;
    public GameObject panelError;
    public GameObject panelRespuesta;
    public GameObject Btn_jugarOtraVez;
    public Text textNotificaciones;
    public GameObject Btn_MasJuegos;
    public GameObject[] objetos;

    public string Selected;

    public Text valor1;
    public Text valorTotal;

    public Text Articulo1;
    public Text Articulo2;
    public Text Articulo3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cambioColorD()
    {
        Articulo1.color = Color.red;
        Articulo2.color = Color.black;
        Articulo3.color = Color.black;

        Selected = "1";
    }
    public void cambioColorM()
    {
        Articulo1.color = Color.red;
        Articulo2.color = Color.black;
        Articulo3.color = Color.black;

        Selected = "2";
    }
    public void cambioColorI()
    {
        Articulo1.color = Color.red;
        Articulo2.color = Color.black;
        Articulo3.color = Color.black;

        Selected = "3";
    }


    public void BotonApretar()
    {
        if (Selected == "")
        {
            panelError.SetActive(true);
            panelRespuesta.SetActive(false);
        }

        if (Selected == "1")
        {
            panelNotificaciones.SetActive(true);
            if (precioDeArriba + precioDeAbajoD == Valor)
            {
                txtGanaste.text = "Ganaste";
                Buttontxtjugar.text = "Reiniciar el desafío";
            }
            else
            {
                txtGanaste.text = "Perdiste";
                Buttontxtjugar.text = "Volver a intentarlo";
            }
        }

        else if (Selected == "2")
        {
            panelNotificaciones.SetActive(true);
            if (precioDeArriba + precioDeAbajoI == Total)
            {
                txtGanaste.text = "Ganaste";
                Buttontxtjugar.text = "Reiniciar el desafío";
            }
            else
            {
                txtGanaste.text = "Perdiste";
                Buttontxtjugar.text = "Volver a intentarlo";
            }
        }

        else if (Selected == "3")
        {
            panelNotificaciones.SetActive(true);
            if (precioDeArriba + precioDeAbajoM == Total)
            {
                txtGanaste.text = "Ganaste";
                Buttontxtjugar.text = "Reiniciar el desafío";
            }
            else
            {
                txtGanaste.text = "Perdiste";
                Buttontxtjugar.text = "Volver a intentarlo";
            }
        }
    }

    public void BotonCerrarPanel()
    {
        panelSelected.SetActive(false);
    }
    public void BotonCerrarPanelNotificaciones()
    {
        if (Buttontxtjugar.text == "Volver a intentarlo")
        {
            panelNotificaciones.SetActive(false);
        }
    }
    public void ReiniciarJuego()
    {
        if (Buttontxtjugar.text == "Reiniciar el desafío")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            GenerarRandom();
        }

    }
    public void CambiarEscena()
    {
        SceneManager.LoadScene("SeleccionarJuego");
    }
}


public void ButtonResponderClick()
    {
        if (Selected == "")
        {
            panelError.SetActive(true);
            panelRespuesta.SetActive(false);
        }
        else if (Selected = n)
        {
            panelNotificaciones.SetActive(true);
            panelRespuesta.SetActive(false);
            textNotificaciones.text = "El resultado es correcto";
            Btn_jugarOtraVez.SetActive(true);
            Btn_MasJuegos.SetActive(true);
        }
        else if (Selected =n2)
        {
            panelNotificaciones.SetActive(true);
            panelRespuesta.SetActive(false);
            textNotificaciones.text = "El resultado es incorrecto";
            Btn_jugarOtraVez.SetActive(true);
            Btn_MasJuegos.SetActive(true);
        }

        else if (Selected = n3)
        {
            panelNotificaciones.SetActive(true);
            panelRespuesta.SetActive(false);
            textNotificaciones.text = "El resultado es incorrecto";
            Btn_jugarOtraVez.SetActive(true);
            Btn_MasJuegos.SetActive(true);
        }
    }

    public void Salir()
    {
         SceneManager.LoadScene("Seleccionar Mas Juegos");
    }
}
