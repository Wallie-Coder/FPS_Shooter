using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_player_to_scenes : MonoBehaviour
{
    public GameObject menu;
    public bool showmenu = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            showmenu = !showmenu;
            
        }

        menu.SetActive(showmenu);
        Cursor.visible = showmenu;
    }
}
