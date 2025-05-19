using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableHints : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Text text2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            
                text.enabled = false;
            
        }  
        else if (Input.GetKeyUp(KeyCode.F)){
            text2.enabled = false;
        }
    }
}
