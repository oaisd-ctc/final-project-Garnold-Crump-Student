using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
    
{
    public Canvas canvas;
    public MarketOpend marketOpend;
    public Image li;
    public Image l2;
    public Image c1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) {
            canvas.enabled = true;
        }
        if(canvas.enabled == true)
        {
            Cursor.lockState = CursorLockMode.None;
            if (Input.GetKeyDown(KeyCode.Escape)) { Cursor.lockState = CursorLockMode.Locked;  canvas.enabled = false; } }
        if(marketOpend.completed == true)
        {
            l2.enabled = true;
            li.enabled = true;
            c1.enabled = true;
        }
     
    }
    
}
