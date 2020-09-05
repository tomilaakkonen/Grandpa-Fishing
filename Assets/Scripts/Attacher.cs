using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacher : MonoBehaviour {

    public bool Attached;

    public Transfer transfer;
    void OnCollisionEnter(Collision col)
    {
        GameObject.Find("Cable_end");
        if (Attached)
        {
            return;
          
        }
        else if (col.gameObject.tag == "Hook")
        {
         
            FixedJoint joint = gameObject.AddComponent<FixedJoint>();
            joint.anchor = col.contacts[0].point;
            joint.connectedBody = col.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody>();
            joint.enableCollision = false;
            Attached = true;
            transfer.ChangeTag();
            
        } else
        {
            return;
        }

    } 


}
