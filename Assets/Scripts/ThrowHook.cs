using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowHook : MonoBehaviour {

    public GameObject Hook;
    public bool ropeActive;


    GameObject curHook;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if(Input.GetMouseButtonDown(0)) {
            if (ropeActive == false)
            {
                Vector2 destiny = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                curHook = (GameObject)Instantiate(Hook, transform.position, Quaternion.identity);

                curHook.GetComponent<Rope2>().destiny = destiny;

                ropeActive = true;
            } else {
                Destroy(curHook);

                ropeActive = false;
            }
                
        }
	}
}
