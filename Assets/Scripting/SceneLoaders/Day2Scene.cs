using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day2Scene : MonoBehaviour
{ public DontDestroy  dont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string current = SceneManager.GetActiveScene().name;
        if (current == "Day2")
        {
            dont.all.SetActive(true);
        }
       
        if (current != "Day2") { DontDestroyOnLoad(dont.all); }
    }
}
