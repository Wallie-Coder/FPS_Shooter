using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mag_level : MonoBehaviour
{

    public GameObject magazine_upgrade;
    public float new_magaz_level;


    // Start is called before the first frame update
    void Start()
    {
        magazine_upgrade = GameObject.FindWithTag("magazine_upgrade");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        new_magaz_level = magazine_upgrade.GetComponent<magazine_upgrade>().level;
        
    }
}
