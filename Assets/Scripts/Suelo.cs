using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{

    public Vidas vida;
    // Start is called before the first frame update
    private void OnTriggerEnter()
    {
        vida.PerderVida();
    }
}
