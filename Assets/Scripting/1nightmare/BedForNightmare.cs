using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BedForNightmare : MonoBehaviour
{
    
    public GameObject player;
    public Text bedtext;
    public string SceneName;
    public RawImage eye1;
    public RawImage eye2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Vector3.Distance(transform.position, player.transform.position) <= 4)
            {
                bedtext.enabled = true;
          
            eye1.enabled = false;
            eye2.enabled = false;
            
            if (Input.GetKeyDown(KeyCode.E))
                {
                    Invoke("LoadScene", 0.1f);
                bedtext.enabled = false;
            }
            
        }
        if (Vector3.Distance(transform.position, player.transform.position) >= 4)
        {
            bedtext.enabled = false;
            eye1.enabled = true;
            eye2.enabled = true;
        }
        
    }
    void LoadScene()
    {
        SceneManager.LoadScene(SceneName);

        
    }

   
}
