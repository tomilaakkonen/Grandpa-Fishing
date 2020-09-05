using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope2 : MonoBehaviour {

    public Vector2 destiny;
    public float speed = 1;
    public float distance = 2;
    public GameObject NodePrefab;
    public GameObject rodhand;
    public GameObject lastNode;
    bool done = false;

	// Use this for initialization
	void Start () {

        rodhand = GameObject.FindGameObjectWithTag("Player");

        lastNode = transform.gameObject;
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector2.MoveTowards(transform.position, destiny, speed);

        if((Vector2)transform.position != destiny) {

            if (Vector2.Distance(rodhand.transform.position, lastNode.transform.position) > distance)
            {


                CreateNode();

            }


        }
        else if (done == false)
        {

            done = true;


            lastNode.GetComponent<HingeJoint2D>().connectedBody = rodhand.GetComponent<Rigidbody2D>();
        }



    }


    void CreateNode()
    {

        Vector2 pos2Create = rodhand.transform.position - lastNode.transform.position;
        pos2Create.Normalize();
        pos2Create *= distance;
        pos2Create += (Vector2)lastNode.transform.position;

        GameObject go = (GameObject)Instantiate(NodePrefab, pos2Create, Quaternion.identity);


        go.transform.SetParent(transform);

        lastNode.GetComponent<HingeJoint2D>().connectedBody = go.GetComponent<Rigidbody2D>();

        lastNode = go;


    }



}