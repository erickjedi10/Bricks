using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Barra : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidad = 10f;
    public float posX = 0.0f;
    public Vector3 posicionInicial;
    public Controltouch izquierdo;
    public Controltouch Derrecho;

    void Start()
    {
        posicionInicial = transform.position;
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }


    // Update is called once per frame
    void Update()
    {
        float direction;
        if (izquierdo.pulsar == true)
        {
            direction = -1;
        }
        else if (Derrecho.pulsar == true)
        {
            direction = 1;
        } else direction = Input.GetAxisRaw("Horizontal"); 


       
        float posX = transform.position.x + (direction * velocidad * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(posX,263,279), transform.position.y, transform.position.z);
      
        // Debug.Log(Time.deltaTime);
    }
}
