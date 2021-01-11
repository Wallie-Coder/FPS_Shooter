using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazine_upgrade : MonoBehaviour
{
    public GameObject world_scores;
    public float munten = 0;
    public float level = 0;
    public bool clicked = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        world_scores = GameObject.FindWithTag("upgrades");
        munten = world_scores.GetComponent<world_points>().score;


        level = world_scores.GetComponent<world_points>().new_magazine_level;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        munten = world_scores.GetComponent<world_points>().score;

        if (clicked == true)
        {
            clicked = false;
            if (munten >= 20)
            {
                level += 1;
            }
        }


    }

    public void oOnclick()
    {
        clicked = true;
    }
    
}
