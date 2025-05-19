using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnLeaveStartTime : MonoBehaviour
{
    public float time = 60f;
    public bool start;
    public Text countdownDisplay;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(start == true)
        {
           text.text = "You have one minute to save your farm";
            Invoke("timestart", 2f);
        }
        if(time <= 0)
        {
            countdownDisplay.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        string current = SceneManager.GetActiveScene().name;
        if (current == "Day3")
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player)
            {
                start = true;
            }
        }
    }
    public void timestart()
    {
        
        time -= Time.deltaTime;
        int rounded = Convert.ToInt32(time);
        countdownDisplay.text = rounded.ToString();
        text.enabled = false;
    }
}
