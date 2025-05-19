using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ToDoList : MonoBehaviour
{
    private float range = 1.5f;
    public GameObject player;
    public Text ToDo;
    public Image ListGraphics;
    public MeshRenderer ListRenderer;
    public Image button;
  private bool ListPickedUp;
    private bool DisableText;
     private bool EnableCursor;
    public Text obj1;
    public Text obj2;
    public Text obj3;
    public Text obj4;
    public Text obj5;
    public Image i1;
    public Image i2;
    public Image i3;
    public GameObject note;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ListPickedUp == true)
        {
            Note();
          
            if(DisableText == true)
            {
                ExitNote();
            }
        }
       
     else   if(Vector3.Distance(transform.position, player.transform.position) <= range)
        {
            if(Input.GetKeyDown(KeyCode.E)) {
              ListRenderer.enabled = false;
                ListPickedUp = true;
                obj4.enabled = false;
                obj5.enabled = true;
            }
            
        }

       
    }
    void Note()
    {
        if (ListPickedUp == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                obj5.enabled = false;
                ListGraphics.enabled = true;
                DisableText = true;
               
                ToDo.enabled = true;

                button.enabled = true;
                obj1.enabled = true;
                obj2.enabled = true;
                obj3.enabled = true;
                i1.enabled = true;
                i2.enabled = true;
                i3.enabled = true;
                Cursor.lockState = CursorLockMode.None;
               
                
            }
        }
      
    }
    void ExitNote()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ListGraphics.enabled = false;
            ToDo.enabled = false;
            button.enabled = false;
            obj1.enabled = false;
            obj2.enabled = false;
            obj3.enabled = false;
            obj5.enabled = false;
            i1.enabled= false;
            i2.enabled=false;
            i3.enabled=false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
