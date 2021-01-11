using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_tutorial : MonoBehaviour
{
    public GameObject thing;

    // Start is called before the first frame update
    void Start()
    {
        thing = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicking()
    {
        thing.GetComponent<Rigidbody>().velocity = transform.forward * 6;
        Invoke("LoadTutorial", 1.75f);
    }
    public void LoadTutorial()
    {
        
        SceneManager.LoadScene("Tutorial");
    }
}
