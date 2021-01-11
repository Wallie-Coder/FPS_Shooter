using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{

    public GameObject explosion;
    public GameObject Bomb;
    public Collider bomb_collis;

    public float x = 1;
    public float y = 1;
    public float z = 1;

    // Start is called before the first frame update
    void Start()
    {
        bomb_collis = GetComponent<Collider>();
        Invoke("start_collider", 0.5f);
        bomb_collis.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        x = Bomb.transform.position.x;
        y = Bomb.transform.position.y;
        z = Bomb.transform.position.z;

        Invoke("destroy", 0f);
        Instantiate(explosion, new Vector3(x, y, z), Quaternion.identity);
    }
    public void destroy()
    {
        Destroy(gameObject);
    }
    public void start_collider()
    {
        bomb_collis.enabled = true;
    }
}
