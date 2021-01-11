using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{

    public float Health = 10;
    public bool attacked = false;
    public Text levens;
    

    public float sliderheath = 10;
    public Slider HP;

    public GameObject world_points;
    

    // Start is called before the first frame update
    void Start()
    {
        world_points = GameObject.FindWithTag("upgrades");
        Health = world_points.GetComponent<upgrades>().Max_Health_player;
        HP.GetComponent<Slider>().maxValue = Health;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if(Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        HP.GetComponent<Slider>().value = Health;

    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            if(attacked == true)
            {
                attacked = false;
                Invoke("Attacked", 1f);
                Health -= 1;
            }
        }
    }
    private void OnCollisionEnter(Collision collis)
    {
        if(collis.collider.tag == "Enemy")
        {
            attacked = true;
        }
        if(collis.collider.tag == "enemy_bullet")
        {
            Health -= 1;
            Destroy(collis.collider);
        }
        if (collis.collider.tag == "explosion")
        {
            Health -= 1;
            
        }
    }
    private void Attacked()
    {

        attacked = true;

    }
    
}
