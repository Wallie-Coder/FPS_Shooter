using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_scene_upgrades : MonoBehaviour
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

    public void clicked()
    {
        thing.GetComponent<Rigidbody>().velocity = transform.forward * 6;
        Invoke("LoadUpgrades", 1.75f);


    }

    public void LoadUpgrades()
    {
        SceneManager.LoadScene("upgrade");
    }
}
