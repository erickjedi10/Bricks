using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{
    // Start is called before the first frame update
    public bool salir = false;

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (salir)
            {
                Application.Quit();

            }
            else 
            {

                SceneManager.LoadScene(0);

            }
        }
    }
}
