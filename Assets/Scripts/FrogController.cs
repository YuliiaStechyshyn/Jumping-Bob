using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{

    public float jumpSpeed = 5f;//or whatever you want it to be
    public Rigidbody rb; //and again, whatever you want to call it
    public float  forward ;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

      if (Input.GetButton("Fire1"))
        {
            rb.velocity = new Vector3(-3, 3, 0);
           
        }

    }
  


}
