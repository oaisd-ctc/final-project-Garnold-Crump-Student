using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedAllTasks : MonoBehaviour
{
    public WaterPlantsObj waterPlantsObj;
    public SellCorn sellCorn;
    public Ontrigger ontrigger;
    public bool sleep;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(waterPlantsObj.complete3 == true)
        {
            if(sellCorn.complete2 == true)
            {
                if(ontrigger.complete1 == true)
                {
                   sleep = true;
                   
                }
            }
        }
    }
}
