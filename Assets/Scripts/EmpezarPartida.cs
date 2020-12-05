using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour
{
    // Start is called before the first frame update
    public bool iniciar;
    public Controltouch BotonInicio;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) || BotonInicio.pulsar == true)
        {
            if (iniciar)
            {
                SceneManager.LoadScene(1);
                Vidas.vidas = 4;
                Puntos.puntos = 0;
            }
            else Application.Quit();

        }
    }
}
