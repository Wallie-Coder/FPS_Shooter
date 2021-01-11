using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class upgrades : MonoBehaviour
{

    public float existing = 1;
    private static upgrades jes;
    public float bulletamount = 6;

    public float old_magazine_level = 0;
    public float new_magazine_level = 0;
    public GameObject magazine_upgrade;

    public float Max_Health_player = 10;
    public GameObject Health_upgrade;
    public float new_max_health;
    public float old_max_health;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

        if (jes == null)
        {
            jes = this;
        }
        else
        {
            DestroyObject(gameObject);
        }



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name == "upgrade")
        {

            magazine_upgrade = GameObject.FindWithTag("new_mag_level");
            new_magazine_level = magazine_upgrade.GetComponent<mag_level>().new_magaz_level;
            if (new_magazine_level != old_magazine_level)
            {
                old_magazine_level = new_magazine_level;
                bulletamount += 2;
            }
                            

        }
        if (SceneManager.GetActiveScene().name != "upgrade")
        {
            new_magazine_level = 0;
            old_magazine_level = 0;
            new_max_health = 0;
            old_max_health = 0;

        }

        if (SceneManager.GetActiveScene().name == "upgrade")
        {

            Health_upgrade = GameObject.FindWithTag("max_health_level");
            new_max_health = Health_upgrade.GetComponent<Health_max_level>().max_hea_level;

            if (new_max_health != old_max_health)
            {
                old_max_health = new_max_health;
                Max_Health_player += 5;
            }
        }

    }
        
}
