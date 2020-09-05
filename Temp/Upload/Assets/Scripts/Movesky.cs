using UnityEngine;
using System.Collections;

public class Movesky : MonoBehaviour
{
    public float speed;
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        transform.Translate((new Vector3(-1, 0, 0)) * speed * Time.deltaTime);
    }
}