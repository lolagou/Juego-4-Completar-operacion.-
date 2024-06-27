using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Btn_jugarOtraVez;
    public Button ResponderBtn;
    public Button Btn_MasJuegos;

    public string Selected;
    public GameObject panelSelected;
    public GameObject notificacionPanel;



    void Start()
    {
        notificacionPanel.SetActive(true);

        if (ResponderBtn)
        {

            ResponderBtn.GetComponent<Text>().text = "Reiniciar desafio";
           


        }

        if (Btn_jugarOtraVez)
        {
            //si la respuesta es correcta
            Btn_jugarOtraVez.GetComponentInChildren<Text>().text = "Jugar otra vez";
        }

        if (Btn_MasJuegos)
        {
            //si la respuesta es incorrecta
            Btn_MasJuegos.GetComponentInChildren<Text>().text = "Mas Juegos";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



}

  