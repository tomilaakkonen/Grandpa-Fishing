using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float speed = 5.0f;

	
	// Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RightArrow();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LeftArrow();
        }


        Vector3 euler = transform.eulerAngles;
        if (euler.z > 180) euler.z = euler.z - 360;
        euler.z = Mathf.Clamp(euler.z, -80, 25);
        transform.eulerAngles = euler;

    }

    public void LeftArrow()
    {
        transform.Rotate(Vector3.forward, speed);
    }

    public void RightArrow()
    {
        transform.Rotate(Vector3.back, speed);
    }

}
