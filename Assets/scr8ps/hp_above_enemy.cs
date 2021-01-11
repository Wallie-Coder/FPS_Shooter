using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_above_enemy : MonoBehaviour
{

    public float Levens = 5;
    public Text HP;
    public float Hits = 0;


    // Start is called before the first frame update
    void Start()
    {
        HP.text = ("HP  " + Levens);

        
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = ("HP  " + Levens);

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
