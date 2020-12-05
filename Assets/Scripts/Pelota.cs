using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{

    public Rigidbody rig = new Rigidbody();
    public float velocidad = 600f;
    public bool enJuego = false;
    Vector3 posicionInicial;
    public Transform barra;
    public Controltouch pantalla;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }
    
    
    
    
    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMov();
        
    }

    public void DetenerMov() 
    {
        rig.isKinematic = true;
        rig.velocity = new Vector3(0,0,0);

    }

    // Update is called once per frame
    void Update()
    {

            if (enJuego == false && Input.GetButtonDown("Fire1") || pantalla.pulsar == true)
            {
                enJuego = true;
                transform.SetParent(null);
                rig.isKinematic = false;
                rig.AddForce(new Vector3(velocidad, velocidad, 0));
            }
       
    }
}
