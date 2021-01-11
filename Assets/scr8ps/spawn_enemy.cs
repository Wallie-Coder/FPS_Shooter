using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
{

    public bool just_spawned = false;
    public GameObject Enemy1;
    public float spawntime = 5;
    public GameObject eachenemy;
    public float Movespeed_enemy_1;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(just_spawned == false)
        {
            just_spawned = true;
            Invoke("spawnenemy", spawntime);
        }
        



    }
    private void spawnenemy()
    {
        GameObject bullet = Instantiate(Enemy1) as GameObject;
        bullet.transform.position = new Vector3(transform.position.x, transform.position.y + 2.6f, transform.position.z);
        just_spawned = false;
    }
    
}
