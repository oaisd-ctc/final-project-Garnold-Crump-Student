using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlants : MonoBehaviour
{
    public ParticleSystem water;
    public GameObject PickUpObject;
    public GameObject Hands;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if( PickUpObject.transform.parent == Hands.transform)
        {
if(Input.GetMouseButtonDown(0))
            {
                water.Play();   
              
            }
        }
       if(Input.GetMouseButtonUp(0))
        {
            water.Stop();
         
        }
    }
}
