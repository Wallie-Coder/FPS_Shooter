using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;

public class Enemy_range : MonoBehaviour
{
    public Transform target;
    public float walkspeed = 2;
    public Rigidbody enemy_range;
    public float distance = 20;
    public float shootspeed = 2;

    public bool shot = false;
    public GameObject bullets;

    

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(target);
        enemy_range.velocity = transform.forward * walkspeed;

        distance = Vector3.Distance(target.position, transform.position);
        if(distance <= 15)
        {
            walkspeed = 0;
            if(shot == false)
            {
                shot = true;
                Invoke("shoot", shootspeed);
            }
        }
        else
        {
            walkspeed = 4;
        }

        
    }

    public void shoot()
    {
        
        transform.LookAt(target);

        GameObject E_bullets = Instantiate(bullets) as GameObject;
        E_bullets.transform.position = new Vector3(enemy_range.transform.position.x, enemy_range.transform.position.y + 0.75f, enemy_range.transform.position.z);
        
        Rigidbody rb = E_bullets.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 5;
        

        shot = false;
    }
        
}
