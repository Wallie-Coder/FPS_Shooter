using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_body : MonoBehaviour
{

    public Rigidbody body;
    
    public float walkspeed = 4;
    public float sprintspeed = 6;
    public float movespeed = 4;
    public float Horizontal = 0f;
    public float sensitivity = 2;
    public float Y = 0.2f;
       

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Horizontal += sensitivity * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, Horizontal, 0);


        


            if (Input.GetKey("d"))
            {
                transform.position += transform.right * Time.deltaTime * walkspeed;
            }
            if (Input.GetKey("s"))
            {
                transform.position += -transform.forward * Time.deltaTime * walkspeed;

            }
            if (Input.GetKey("a"))
            {
                transform.position += -transform.right * Time.deltaTime * walkspeed;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
            
            walkspeed = sprintspeed;
            
            }
            if (Input.GetKey("w"))
            {
                transform.position += transform.forward * Time.deltaTime * walkspeed;

            }
            else
            {
                walkspeed = movespeed;
            }
            if(!Input.anyKeyDown)
            {
                body.velocity = Vector3.zero;
            
        }
           

        

    }
    
}
