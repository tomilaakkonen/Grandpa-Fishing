using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LineIn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private Controller theController;
    private CableComponent theCable;
    // Use this for initialization
    public bool buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
    void Start()
    {
        theController = FindObjectOfType<Controller>();
        theCable = FindObjectOfType<CableComponent>();
    }

    void Update()
    {
        if (buttonPressed == true)
        {
            theCable.ButtonIn();
        }
        else
        {
            return;
        }
    }
}
