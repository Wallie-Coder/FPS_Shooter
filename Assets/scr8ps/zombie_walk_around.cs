using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_walk_around : MonoBehaviour
{

    public Rigidbody mainscreenenemy;
    public float walkspeed = 4;
    public bool turn = true;
    public float turnaftertime = 1;

    // Start is called before the first frame update
    void Start()
    {
        mainscreenenemy.velocity = transform.forward * walkspeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        mainscreenenemy.velocity = transform.forward * walkspeed;
        if(turn == true)
        {
            Invoke("Turns", turnaftertime);
            turn = false;
        }
        

    }

    public void Turns()
    {
        mainscreenenemy.transform.Rotate(0, transform.rotation.y + 180, 0, 0);
        turn = true;
    }
}
