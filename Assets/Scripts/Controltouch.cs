using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controltouch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool pulsar;
    public void OnPointerDown(PointerEventData eventData)
    {
        pulsar = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pulsar = false;
    }

    
}
