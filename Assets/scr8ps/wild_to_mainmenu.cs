using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wild_to_mainmenu : MonoBehaviour
{

    public bool seconddone = true;
    public Text secondsleft;
    public float seconds = 3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        if (seconds <= -1)
        {
            SceneManager.LoadScene("begin_screen");
        }
        if (seconddone == true)
        {
            Invoke("Time1", 1f);
        }

    }
    public void Time1()
    {

        secondsleft.text = ("Teleporing in ") + seconds;
        seconds -= 1;
        Invoke("Clicked", 0f);

    }
}
