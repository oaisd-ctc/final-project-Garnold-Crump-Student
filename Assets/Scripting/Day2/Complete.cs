using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{
    public BoolsImage bools;
    public PlantsGrow plantsGrow;
    public bool Completed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this);
        if(bools.enable == true && plantsGrow.t == true)
        {
            Completed = true;
        }
    }
}
