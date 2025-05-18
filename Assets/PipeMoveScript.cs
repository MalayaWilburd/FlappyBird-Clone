using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 8;
    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed)* Time.deltaTime; //multiplication happens the same as the frame rate; most of the time we need it.

        if (transform.position.x<deadZone)
        {
            Destroy(gameObject);
        }
    }
}
