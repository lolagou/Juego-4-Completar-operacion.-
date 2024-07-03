using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ResponderScript : MonoBehaviour
{

    // Textos y seleccion + Guardado de respuesta 
    public Text[] textos;
    int respuesta;

    // Valores producto 
    public GameObject valoresContainer;

    // Panel asociado + Texto inside 
    public GameObject panel;
    public Text correccionTxt;
    public Text buttonTxt;
    bool respuestaVacia = false; 

    // Comportamiento Buttons
    bool correcto;
    public ProductosRandom randomProducts;
    public GameObject[] objetosEliminar;
    const string nombre1 = "Bertoloni_Lucas_48243379(Clone)";
    const string nombre2 = "Alfie_Joaquin_48178973(Clone)";
    const string nombre3 = "Nuñez Valcarce_Ignacio_48044118(Clone)";
    const string nombre4 = "Nuñez Gouget_Lola Emma_48180795(Clone)"; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckeoSeleccion()
    {
        if (textos[0].color == Color.blue)
        {
            respuesta = int.Parse(textos[0].text.Substring(1));
        }
        else if (textos[1].color == Color.blue)
        {
            respuesta = int.Parse(textos[1].text.Substring(1));
        }
        else if (textos[2].color == Color.blue)
        {
            respuesta = int.Parse(textos[2].text.Substring(1));
        }

        int valorCorrecto = valoresContainer.GetComponent<ProductosRandom>().precioCorrecto;
        if (respuesta == valorCorrecto)
        {
            panel.SetActive(true);
            correccionTxt.text = "¡Respuesta correcta!";
            buttonTxt.text = "Reiniciar el desafío";
            correcto = true; 
        }
        else if (respuesta != valorCorrecto)
        {
            panel.SetActive(true);
            correccionTxt.text = "Respuesta incorrecta";
            buttonTxt.text = "Volver a intentarlo";
            correcto = false; 
        }
    }
    public void ButtonManager()
    {
        if (correcto)
        {
            panel.SetActive(false); 
            objetosEliminar = GameObject.FindObjectsOfType<GameObject>();
            foreach (GameObject g in objetosEliminar)
            {
                switch (g.name)
                {
                    case nombre1:
                        Destroy(g);
                        break;

                    case nombre2:
                        Destroy(g);
                        break;

                    case nombre3:
                        Destroy(g);
                        break;

                    case nombre4:
                        Destroy(g);
                        break;
                }
            }

            foreach (Text t in textos)
            {
                t.color = Color.black;
                t.fontStyle = FontStyle.Normal; 
            }
            randomProducts.Start(); 
        }
        else
        {
            foreach(Text t in textos)
            {
                t.color = Color.black;
                t.fontStyle = FontStyle.Normal;
            }
            panel.SetActive(false);
        }
    }
    public void Quit()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    public void ChangeScene(string nombreScene)
    {
        SceneManager.LoadScene(nombreScene);
    }
}
