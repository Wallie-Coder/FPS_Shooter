using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class move_giant_enemy : MonoBehaviour
{
    public bool looked_at = false;
    public Transform target;
    public Rigidbody rb;
    public float walkspeed = 3;
    public Vector3 targetposition;
    public float distance;

    public float walkanimation = 1f;
    public float animation_speed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (looked_at == false)
        {
            Invoke("Look", 0f);
        }
        distance = Vector3.Distance(target.position, transform.position);
    }
    public void Look()
    {
        targetposition = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(targetposition,Vector3.up);
        rb.velocity = transform.forward * walkspeed;
        if (distance <= 7)
        {
            
            walkspeed = 0;
        }
        else
        {
            walkspeed = 3;
        }

        walkanimation = Mathf.PingPong(animation_speed, 3);
    }
}
