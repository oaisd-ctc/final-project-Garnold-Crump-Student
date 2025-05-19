using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActive : MonoBehaviour
{
    public GameObject setActive;
    public GameObject setActive2;
    public GameObject updateActive;
    public GameObject setActive3;
    public GameObject setActiveCanvas;
    public GameObject Tablet;
    public GameObject CanvasCam;

   
    // Start is called before the first frame update
    void Start()
    {
        string current = SceneManager.GetActiveScene().name;
        DontDestroyOnLoad(updateActive);
        if (current == "NightMare")
        {
            CanvasCam.SetActive(true);

        }


    }

    // Update is called once per frame
    void Update()
    {
       
     
        string current = SceneManager.GetActiveScene().name;
        if (current == "Day2")
        {
            setActiveCanvas.SetActive(true);
            Tablet.SetActive(true);
            setActive.SetActive(true);
            setActive2.SetActive(true);
            setActive3.SetActive(true);
            
        }
       
      
    }
   
}
