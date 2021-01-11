using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss_win_sequence : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boss;

    public bool win = false;
    public GameObject explosions;
    public bool wonstarted = false;
    public float duration = 2f;
    public bool keepgoing = true;
    public Text wintext;

    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("boss");




    }

    // Update is called once per frame
    void Update()
    {
        win = boss.GetComponent<boss_health>().you_won;
        if (win == true && wonstarted == false)
        {
            wonstarted = true;
            Invoke("WWin", 0.1f);
            Invoke("ending", duration);
            Invoke("tofinal", 7f);
        }
        
    }
    void ending()
    {
        keepgoing = false;
        
    }
    void tofinal()
    {
        
        SceneManager.LoadScene("FinalSunSet");
    }
    void WWin()
    {
        GameObject explos = Instantiate(explosions) as GameObject;
        explos.transform.position = new Vector3(0, 12, 1);
        if(keepgoing == true)
        {
            Invoke("WWin2", 0.1f);
        }
    }
    void WWin2()
    {
        GameObject explos = Instantiate(explosions) as GameObject;
        explos.transform.position = new Vector3(2, 11, -2);
        Invoke("WWin3", 0.1f);
    }
    void WWin3()
    {
        GameObject explos = Instantiate(explosions) as GameObject;
        explos.transform.position = new Vector3(1, 13, 0);
        Invoke("WWin4", 0.1f);
    }
    void WWin4()
    {
        GameObject explos = Instantiate(explosions) as GameObject;
        explos.transform.position = new Vector3(-1, 10, 2);
        Invoke("WWin5", 0.1f);
    }
    void WWin5()
    {
        GameObject explos = Instantiate(explosions) as GameObject;
        explos.transform.position = new Vector3(-2, 12, 0);
        Invoke("WWin", 0.1f);
    }
}
