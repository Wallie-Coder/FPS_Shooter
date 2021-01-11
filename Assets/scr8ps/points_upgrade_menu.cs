using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points_upgrade_menu : MonoBehaviour
{
    public GameObject asdfasdf;
    public float punten;
    public Text punten_upgrade_scherm;


    // Start is called before the first frame update
    void Start()
    {
        asdfasdf = GameObject.FindWithTag("upgrades");
    }

    // Update is called once per frame
    void Update()
    {
        punten = asdfasdf.GetComponent<world_points>().score;

        punten_upgrade_scherm.text = ("Points = ") + punten;
    }
}
