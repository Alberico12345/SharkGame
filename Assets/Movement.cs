using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float Jump_force;
    public bool moving = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (moving == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Speed);
            if (Input.GetKeyDown("space") && rb.velocity.y <= -2.5)
            {
                //print("space");
                GetComponent<Rigidbody>().AddForce(Vector3.up * Jump_force);
            }

        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            
        }
        
    }   
}
