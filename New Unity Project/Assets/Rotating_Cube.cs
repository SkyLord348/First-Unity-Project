using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotating_Cube : MonoBehaviour
{
 
    public Vector3 editRotation;
    public Keyboard keyboard;


    void Start()
    {
        keyboard = Keyboard.current;




    }



    void Update()
    {

        if (keyboard == null)
        {

            Debug.Log("no keyboard");

            return;
            
        }

        if (keyboard.wKey.isPressed)
        {
            transform.Rotate(editRotation * Time.deltaTime);

            Debug.Log("Update");


        }





    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void FixedUpdate()
    {

    }
}
