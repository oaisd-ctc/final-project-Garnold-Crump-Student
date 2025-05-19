using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canva : MonoBehaviour
{
    
    public string parentTag = "Obj";
    void Update()
    {
        // Find all game objects with the specified tag
        GameObject[] parentObjects = GameObject.FindGameObjectsWithTag(parentTag);

        if (parentObjects.Length > 0)
        {
            // Get the first object with the tag
            GameObject parent = parentObjects[0];

            // Make this object a child of the parent
            if (transform.parent != parent.transform)
            {
                transform.SetParent(parent.transform);
            }
        }
        else
        {
            Debug.LogWarning("No objects found with tag: " + parentTag);
        }
    }
}

