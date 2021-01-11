using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class shooter : MonoBehaviour
{

    public GameObject bullets;
    public bool reload = true;
    public float reloadtime = 5f;
    public float magazine = 6f;
    public Text bulletcount;
    public bool reloading_start = false;
    public Rigidbody cameras;

    public GameObject howmanybullets;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        howmanybullets = GameObject.FindWithTag("upgrades");
        magazine = howmanybullets.GetComponent<upgrades>().bulletamount;
        howmanybullets = GameObject.FindWithTag("upgrades");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
               
        if(reload == true)
        {
            bulletcount.text = "Bullets " + magazine;
        }


        if (Input.GetMouseButtonDown(0))
        {
            
            if (reload == true)
            {
                magazine -= 1;
                Invoke("shot", 0f);
                

            }
            if (magazine == 0 && reloading_start == false)
            {
                bulletcount.text = "Reloading . . . ";
                reload = false;
                Invoke("reloaderto", reloadtime);
                reloading_start = true;
                
            }

        }
                
    }
    public void shot()
    {
        GameObject fires = Instantiate(fire) as GameObject;
        fire.transform.position = transform.position;
        GameObject bullet = Instantiate(bullets) as GameObject;
        bullet.transform.position = transform.position;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 40;

        

    }
    
    public void reloaderto()
    {

        magazine = howmanybullets.GetComponent<upgrades>().bulletamount; ;
        reload = true;
        reloading_start = false;
        
    }
    
}
