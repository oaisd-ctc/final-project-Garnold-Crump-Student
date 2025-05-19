using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class Bed : MonoBehaviour
{
    // Start is called before the first frame update
    public CompletedAllTasks completedAllTasks;
    public GameObject player;
    public Text bedtext;
    public string SceneName;
    public GameObject bed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (completedAllTasks.sleep == true)
        {
            if (Vector3.Distance(transform.position, player.transform.position) <= 4)
            {
                bedtext.enabled = true;
                if(Input.GetKeyDown(KeyCode.E)) {
                    Invoke("LoadScene", 0.1f);
                    bedtext.enabled=false;
                }
            }
        }
        if (Vector3.Distance(transform.position, player.transform.position) >= 4)
        {
            bedtext.enabled = false;
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
