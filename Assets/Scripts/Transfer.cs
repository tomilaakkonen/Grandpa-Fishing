using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transfer : MonoBehaviour {

    private void Start()
    {
        gameObject.tag = "Hook";
    }
    public void ChangeTag()
    {
        gameObject.tag = "Hooked";
    }
    public void hookTag()
    {
        gameObject.tag = "Hook";
    }
}
