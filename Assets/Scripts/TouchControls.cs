using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControls : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private Controller theController;
    private CableComponent theCable;
	// Use this for initialization
	void Start () {
        theController = FindObjectOfType<Controller>();
        theCable = FindObjectOfType<CableComponent>();
	}

    public bool buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    public void Left() { 
        theController.LeftArrow();
   
        }
    public void Right()
    {
        theController.RightArrow();
    }
    public void ButtonInner()
    {
        theCable.ButtonIn();
    }
    public void ButtonOutter()
    {
        theCable.ButtonOut();
    }
	// Update is called once per frame
	void Update () {
            if (buttonPressed = true)
            {
                theController.LeftArrow();
            }
        }
}
