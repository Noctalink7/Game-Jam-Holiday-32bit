using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCamRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject cam;
    bool ispressed = false;

    void Update()
    {
        if (ispressed)
        {
            if (cam.transform.position.x < 14)
                cam.transform.Translate(0.2f, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
