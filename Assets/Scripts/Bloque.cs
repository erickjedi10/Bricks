using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public GameObject particula;
    public Puntos puntito;


    void OnCollisionEnter() 
    {
        Destroy(gameObject);
        Instantiate(particula, transform.position, Quaternion.identity);

        puntito.Sumapuntos();


    }
}
