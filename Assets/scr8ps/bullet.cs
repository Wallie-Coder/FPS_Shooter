﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject rb;
    public float bullettime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Destroy", bullettime);
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
    
}


