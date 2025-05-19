using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterPlantsObj : MonoBehaviour
{
    public Image check;
    public Image line;
    public WaterdPlants waterdPlants;
    public ParticleSystem waterDrops;
    public Image note;
    public Renderer arrow;
    public Renderer arrow2;
    public Renderer arrow3;
    public bool complete3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (waterdPlants.particlePlay == true)
        {
            arrow.enabled = false;
            arrow2.enabled = false;
            arrow3.enabled = false;
            complete3 = true;
            if (note.enabled == true)
            {
                check.enabled = true;
                line.enabled = true;
            }
        }
        if(note.enabled == false) {
            check.enabled = false;
                line.enabled = false; }

    }
}
