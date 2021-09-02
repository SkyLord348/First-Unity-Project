using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncing : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 force;


    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            rb.AddForce(force);
            Debug.Log("Landed on Plane");
        }
    }
}
