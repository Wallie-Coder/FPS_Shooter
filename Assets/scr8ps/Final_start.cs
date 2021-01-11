using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final_start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("end", 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void end()
    {
        SceneManager.LoadScene("begin_screen");
    }
}
