using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Boss_Gun : MonoBehaviour
{

    GameObject player;
    float x = 1;
    float z = 1;
    float y = 1;
    Vector3 target;

    public GameObject bombs;
    public GameObject gun;
    public float speed = 5;
    public bool shot = false;
    public float shootspeed = 4;

    public bool Winning = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Winning == false)
        {
            Winning = gun.GetComponent<boss_health>().you_won;

            x = player.transform.position.x;
            z = player.transform.position.z;
            y = player.transform.position.y;

            target = new Vector3(x, y, z);

            transform.LookAt(target);

            if (shot == false)
            {
                shot = true;
                Invoke("shoot", shootspeed);
            }
        }
        if(Winning == true)
        {
            Invoke("Destroys", 4f);
        }
        
    }

    public void shoot()
    {
        GameObject bomb = Instantiate(bombs) as GameObject;
        bomb.transform.position = new Vector3(gun.transform.position.x, gun.transform.position.y, gun.transform.position.z);

        Rigidbody rb = bomb.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;


        shot = false;
    }

    public void Destroys()
    {
        Destroy(gameObject);
    }
}
