using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightmareLights : MonoBehaviour
{
    public GameObject player;
    public Image run;
    public Text Run;
    public Light light1;
    public Light light2;
    public Light light3;
    public float blinkInterval = 1f;
    public float blinkDuration = 0.5f;
    public bool enterd;
     AudioSource enemyComing;
    public AudioClip enemyisComing;
    void Start()
    {
        enemyComing = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enterd )
        {
           
        }
    }
    private void OnTriggerEnter()
    {
        if (player)
        {
            light1.color = Color.red;
            light2.color = Color.red;
            light3.color = Color.red;
            enterd = true;
            Run.enabled = true;
            run.enabled = true;
            if(run.enabled == true && Run.enabled == true ) { Invoke("RunDisable", 0.5f); }
            enemyComing.clip = enemyisComing;
           
            enemyComing.Play();
        }
    }

    public void RunDisable() {
        Run.enabled = false;
        run.enabled = false;
    }
}
