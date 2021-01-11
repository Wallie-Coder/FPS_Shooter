using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_max_level : MonoBehaviour
{

    public GameObject max_hp_somthing;
    public float max_hea_level;



    // Start is called before the first frame update
    void Start()
    {
        max_hp_somthing = GameObject.FindWithTag("max_health_upgrade");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        max_hea_level = max_hp_somthing.GetComponent<max_HP_upgrade>().max_HP_health_level;
    }
}
