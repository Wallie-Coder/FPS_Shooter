using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class sun_rotate : MonoBehaviour
{

    public Rigidbody sun;
    public float turn = 3;


    // Start is called before the first frame update
    void Start()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, (-turn * Time.deltaTime)-70);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, (-turn * Time.deltaTime));
        transform.LookAt(Vector3.zero);
    }
}
