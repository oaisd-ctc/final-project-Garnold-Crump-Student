using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float time = 20;
    public bool start;
    public Text countdownDisplay;
    public bool chase;
    public GameObject enemy;
    public Complete complete;
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        string current = SceneManager.GetActiveScene().name;
        if (current == "Day3")
        {
            enemy.SetActive(false);
        }
        if (current == "Day2")
        {
            if (complete.Completed == true)
            {
                start = true;


            }
            if (time <= 0)
            {

                countdownDisplay.enabled = false;
                chase = true;
                enemy.SetActive(true);

            }
            if (start == false) { enemy.SetActive(false); }
            if (start == true)
            {
                time -= Time.deltaTime;
                int rounded = Convert.ToInt32(time);
                countdownDisplay.text = rounded.ToString();
            }

        }
    }
}
