using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawer_pingpong : MonoBehaviour
{

    public float speed = 5;
    public float distance = 60;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, distance), transform.position.y, transform.position.z);
    }
}
