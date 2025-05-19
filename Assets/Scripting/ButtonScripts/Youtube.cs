using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Youtube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public  void OnClick()
    { 
        string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        Process.Start(url);
    }
}
