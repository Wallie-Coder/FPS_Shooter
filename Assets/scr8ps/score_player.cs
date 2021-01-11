using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_player : MonoBehaviour
{

    public float points;
    public GameObject world_score;

    public Text Points;


    // Start is called before the first frame update
    void Start()
    {
        world_score = GameObject.FindWithTag("upgrades");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        points = world_score.GetComponent<world_points>().score;

        

        Points.text = "Points = " + points;
    }
}
