
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;


public class world_points : MonoBehaviour
{

    public float score = 0;
    public GameObject[] Enemys;
    public float Hits_per_enemy = 0;
    public float old_hits = 0;

    public float new_magazine_level = 0;
    public float old_magazine_level = 0;
    public GameObject magazine_upgrade;
    public string sceneName;
    public bool in_scene_upgrade;
    public bool mags_updated;

    
    public GameObject Health_upgrade;
    public float new_max_health;
    public float old_max_health;

    

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");


        foreach (GameObject Enemy in Enemys)
        {
            Hits_per_enemy = Enemy.GetComponent<points_for_kiling>().Levens;

            if (Hits_per_enemy <= 0)
            {
                score += 2;
            }
        }
        

        if (Hits_per_enemy != old_hits)
        {

            old_hits = Hits_per_enemy;
        }

        if (SceneManager.GetActiveScene().name == "upgrade")
        {

            magazine_upgrade = GameObject.FindWithTag("new_mag_level");
            new_magazine_level = magazine_upgrade.GetComponent<mag_level>().new_magaz_level;
            if (new_magazine_level != old_magazine_level)
            {
                old_magazine_level = new_magazine_level;
                score -= 20;
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
                score -= 50;
            }
        }



    }
}
