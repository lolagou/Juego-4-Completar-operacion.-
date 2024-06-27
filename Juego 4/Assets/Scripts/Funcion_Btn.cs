using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isCorrect;
    public Button Btn_jugarOtraVez;
    public Button ResponderBtn;
    public Button Btn_MasJuegos;

    public string Selected;
    public GameObject panelSelected;
    public GameObject notificacionPanel;
    
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MostrarPanel()
    {
        notificacionPanel.SetActive(true);

        
        if (isCorrect)
        {
            //si la respuesta es correcta
            Btn_jugarOtraVez.GetComponentInChildren<Text>().text = "Reiniciar el desafío";
        }
        else
        { 
            //si la respuesta es incorrecta
            Btn_jugarOtraVez.GetComponentInChildren<Text>().text = "Volver a intentarlo";
        }
    }

    
public void JugarOtraVez ()
{
    notificacionPanel.SetActive(false);

    if (Btn_jugarOtraVez.GetComponentInChildren<Text>().text == "Reiniciar el desafío")
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

public void SalirAlMenu()  
    {
        notificacionPanel.SetActive(false);
        SceneManager.LoadScene("Seleccionar juegos");  
    }

}
