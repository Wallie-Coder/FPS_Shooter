using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss_health : MonoBehaviour
{
    public Slider boss_healt;
    public float max_boss_health = 3;
    float current_boss_health;

    public bool you_won = false;


    // Start is called before the first frame update
    void Start()
    {
        current_boss_health = max_boss_health;

        boss_healt.GetComponent<Slider>().maxValue = max_boss_health;
    }

    // Update is called once per frame
    void Update()
    {
        if(current_boss_health <= 0)
        {
            you_won = true;
            
        }
        boss_healt.GetComponent<Slider>().value = current_boss_health;
    }

    private void OnCollisionEnter(Collision collis)
    {
        if (collis.collider.tag == "bullet")
        {
            Debug.Log("hit");
            current_boss_health -= 1;
        }
    }
}
