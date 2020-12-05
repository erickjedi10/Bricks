using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour
{

    public AudioSource pelota;
    public AudioSource punto;
    // Start is called before the first frame update
     
    
    void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.CompareTag("block"))
        {
            punto.Play();

        }
        else { pelota.Play(); }
        
    }



}
