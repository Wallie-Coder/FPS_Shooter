using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class max_HP_upgrade : MonoBehaviour
{

    public float max_HP_health_level;
    public float money = 0;
    public GameObject world_poins;
    public bool clicked = false;


    // Start is called before the first frame update
    void Start()
    {
        world_poins = GameObject.FindWithTag("upgrades");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        money = world_poins.GetComponent<world_points>().score;

        if (clicked == true)
        {
            clicked = false;

            if (SceneManager.GetActiveScene().name == "upgrade")
            {
                if (money >= 50)
                {
                    max_HP_health_level += 1;
                }

            }
        }
    }
    public void onClick()
    {

        clicked = true;
    }
}
