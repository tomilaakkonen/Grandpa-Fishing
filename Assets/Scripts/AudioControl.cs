using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {


    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void VolumeTrigger()
    {
        AudioListener.pause = !AudioListener.pause;

    }
        
}
