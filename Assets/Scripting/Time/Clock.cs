using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public float TimeInDay = 86400f;
    public Text clock;
  public  float hours;

    private float elapsedTime;
    private void Start()
    {
        hours = 6;
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;

        float hours = Mathf.FloorToInt(elapsedTime / 3600f);
        float minutes = Mathf.FloorToInt((elapsedTime % 3600) / 60f);
        float seconds = Mathf.FloorToInt(elapsedTime % 60);

        clock.text = string.Format("{0:00} : {1:00}: {2:00}", 6, minutes, seconds); 

    }
}
