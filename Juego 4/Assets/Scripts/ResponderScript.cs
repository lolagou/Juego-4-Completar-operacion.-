using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResponderScript : MonoBehaviour
{
    public GameObject ResponderBtn;
    

    public GameObject panelError;
    public GameObject panelRespuesta;
    public Text textNotificaciones;

    public string Selected;
    public GameObject panelSelected;
    public GameObject panelNotificaciones;
    public Text txtGanaste;
    public Button btnVolverajugar;
    public Text Buttontxtjugar;
    public Button btnSalir;
    public Text ButtontxtSalir;

    private int Total;
    private int Valor;

    public Text Articulo1;
    public Text Articulo2;
    public Text Articulo3;

    int precio0;
    int precio1;
    int precio2;
    int precio3;    


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
            textNotificaciones.text = "Debes seleccionar un producto";

        }

        if (Selected == "1")
        {
            panelNotificaciones.SetActive(true);
            if (precio0 + precio1 == Valor)
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
            if (precio0 + precio2 == Total)
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
            if (precio0 + precio3 == Total)
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
            //randomrange; 
        }

    }
    public void CambiarEscena()
    {
        SceneManager.LoadScene("SeleccionarJuego");
    }
}
