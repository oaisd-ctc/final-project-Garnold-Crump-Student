using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToPlayerParent : MonoBehaviour
{

    void Start()
    {
      
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            
            player.transform.SetParent(player.transform);
          
        }
        else
        {
            Debug.LogWarning("No object with tag 'Player' found.");
        }
    }

 
    void Update()
    {
        
    }
}
