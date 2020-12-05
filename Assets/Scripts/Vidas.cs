using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Vidas : MonoBehaviour

{
    public static int vidas = 4 ;
    public Text textovida;
    public Pelota pelota;
    public Control_Barra barra;
    public GameObject gameover;
    public NextLevel siguientenivel;

    // Start is called before the first frame update
    void Start()
    {
        Actualizarvida();
    }

    void Actualizarvida() 
    {
        textovida.text = "VIDAS: " + Vidas.vidas;
    }

    // Update is called once per frame
    public void PerderVida()  {

        if (Vidas.vidas == 0) { return; }
        Vidas.vidas--;
        Actualizarvida();
        if (Vidas.vidas == 0) 
        {
            gameover.SetActive(true);
            pelota.DetenerMov();
            barra.enabled = false;
            siguientenivel.Nivel = "Portada";
            siguientenivel.ActivarCarga();
            
        }

        pelota.Reset();
        barra.Reset();
    
    }
}
