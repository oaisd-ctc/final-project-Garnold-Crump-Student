using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
  
    }
    private void Update()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Obj");

        if (obj != null)
        {
            // Make this object a child of the player
            transform.SetParent(obj.transform);
        }
        else
        {
            Debug.LogWarning("No object with tag 'Player' found.");
        }
    }

}
