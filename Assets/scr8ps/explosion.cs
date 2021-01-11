using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public bool grew = false;
    Vector3 scalechange;
    public GameObject Explosion;
    public float livetime = 0.3f;
    public float scale = 0.6f;


    // Start is called before the first frame update
    void Start()
    {
        scalechange = new Vector3(scale, scale, scale);
        Invoke("destroyexplosion", livetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(grew == false)
        {
            grew = true;
            Invoke("grow", 0.01f);
        }
    }

    public void grow()
    {
        Explosion.transform.localScale += scalechange;
        grew = false;

    }

    public void destroyexplosion()
    {
        Destroy(Explosion);
    }
}
