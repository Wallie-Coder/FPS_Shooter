using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class points_for_kiling : MonoBehaviour
{

    public TextMeshPro HP;
    public float Levens = 3;
    public float Hits = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HP.text = "HP  " + Levens;
        if (Levens <= 0)
        {

            Hits = 1;

            Invoke("enemy_die", 0f);



        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "bullet")
        {
            Levens -= 1;
            Destroy(collision.gameObject);
                    
        }
    }
    public void enemy_die()
    {
        Destroy(gameObject);
    }
}
