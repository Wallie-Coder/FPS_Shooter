using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour
{
    public Rigidbody rb;
    public Collider collider;
    public float bullettime = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
        collider.enabled = !collider.enabled;
        
               
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("Destroy", bullettime);
        Invoke("enablecollider", 0.1f);
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
    public void enablecollider()
    {
        collider.enabled = !collider.enabled;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    

}
