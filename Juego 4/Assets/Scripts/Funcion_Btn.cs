using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isCorrect;
    private Button Btn_jugarOtraVez;
    public GameObject notificacionPanel;
    
    void Start()
    {
        int precioAzar = Random.Range(0, arrayPrecios.Length);
        precioTotal = precioObjeto4 + arrayPrecios[precioAzar];
        
        notificacionPanel.SetActive(false);

        Btn_jugarOtraVez = buttons[0]; 
        Btn_Salida = buttons[1]; 

        Btn_Salida.onClick.AddListener(SalirAlMenu);
        Btn_jugarOtraVez.onClick.AddListener(JugarOtraVez);

    
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

    public void Resultado(bool result)
    {
        isCorrect = result;
        ShowNotificacion();
    }

}
