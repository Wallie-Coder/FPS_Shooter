﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashofgun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroyyy", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Destroyyy()
    {
        Destroy(gameObject);
    }
}
