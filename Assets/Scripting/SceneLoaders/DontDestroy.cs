using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public GameObject all;
    public Renderer all2;
    public Collider all3;
   
  
    

    // Start is called before the first frame update
    void Start()
    {
       
       
        
    }

    // Update is called once per frame

    void Update()
    {  DontDestroyOnLoad(all);
        if (all2 != null && all3!=null){
            all2 = null;
            all3 = null;
        }
        string current = SceneManager.GetActiveScene().name;
        if (current == "NightMare")
        {
            all2.enabled = false;
            all3.enabled = false;
        }
        if (current != "NightMare")
        {
          all2.enabled=true;
            all3.enabled=true;
          
          
        }
     
       
        
    }
 
}


