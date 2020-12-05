using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public string Nivel;
    public float retraso;

    public void ActivarCarga() 
    {
        Invoke("CargarNivel", retraso);
    
    }

    void CargarNivel() 
    {
        if (!EsultimoLEvel())
        {
            Vidas.vidas++;
        
        }
        SceneManager.LoadScene(Nivel);

    }
    public bool EsultimoLEvel() 
    {
        return Nivel == "Portada";
    
    }



}
