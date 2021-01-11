using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wild1_to_upgrades : MonoBehaviour
{

    public bool seconddone = true;
    public Text secondsleft;
    public float seconds = 4;

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
        if(seconds <= -1)
        {
            SceneManager.LoadScene("upgrade");
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
