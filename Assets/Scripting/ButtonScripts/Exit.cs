using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Image image;
    public Text text;
    public Image button;
    public Text obj1;
    public Text obj2;
    public Text obj3;
    public Text obj5;
    public Image i1;
    public Image i2;
    public Image i3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PhotoExit()
    {
        image.enabled = false;
        text.enabled = false;
        button.enabled = false;
        obj1.enabled = false;
        obj2.enabled = false;
        obj3.enabled = false;
        obj5.enabled = false;
        i1.enabled = false;
        i2.enabled = false;
        i3.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
  
    
}
