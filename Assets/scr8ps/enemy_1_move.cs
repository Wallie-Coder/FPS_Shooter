using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class enemy_1_move : MonoBehaviour
{

    public Transform target;
    public Rigidbody enemy_1;
    public float walkspeed = 3f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        enemy_1.velocity = transform.forward * walkspeed;
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(target);
        enemy_1.velocity = transform.forward * walkspeed;
        
    }
    
}
