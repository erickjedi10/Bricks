using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{

    public static int puntos = 0;
    public Text textop;

    public GameObject nivelCompleot;
    public GameObject JuegoCompleted;

    public NextLevel siguiente;
    public Control_Barra barra;
    public Pelota pelota;
    public Transform bloques;
    

    // Start is called before the first frame update
    void Start()
    {
        Actualizarpuntaje();
    }

    // Update is called once per frame
    void Actualizarpuntaje()
    {
        textop.text = "PUNTOS: " + Puntos.puntos;
    }


    public void Sumapuntos() 
    {
        Puntos.puntos++;
        Actualizarpuntaje();

        if (bloques.childCount == 1) 
        {
            pelota.DetenerMov();
            barra.enabled = enabled;
            if (siguiente.EsultimoLEvel() == true)
            {
                JuegoCompleted.SetActive(true);
            }
            else { nivelCompleot.SetActive(true); }

            siguiente.ActivarCarga();
        }

    }

}
