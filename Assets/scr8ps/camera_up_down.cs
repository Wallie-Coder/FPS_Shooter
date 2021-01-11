using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_up_down : MonoBehaviour
{
    public float Vertical = 0f;
    public float sensitivity = 2;
    public float Horizontal = 0f;
    public Rigidbody body;
    public Rigidbody camera;

    public GameObject player;
    public bool showmenu = false;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()

    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showmenu = !showmenu;

        }

        if (showmenu == false)
        {
            Horizontal += sensitivity * Input.GetAxis("Mouse X");
            Vertical -= sensitivity * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(Vertical, Horizontal, 0);

            camera.transform.position = new Vector3(body.transform.position.x, body.transform.position.y + 1.5f, body.transform.position.z);
        }
        
    }
}
