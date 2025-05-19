using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoolsImage : MonoBehaviour
{ public PlantsGrow plantsGrow;
    public Player player;
    public bool enable;
    public RawImage c1;
    public RawImage l1;
    public RawImage c2;
    public RawImage l2;
    public CountDown countDown;

    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(plantsGrow.t == true)
        {
            c1.enabled = true;
            l1.enabled = true;
        }
        if(plantsGrow.t == false) {
            c1.enabled = false;
            l1.enabled = false;
        }
        if(player.upgraded == true)
        {
            c2.enabled = true;
            l2.enabled = true;
        }
        if(player.upgraded == false)
        {
            c2.enabled= false;
            l2.enabled = false;
        }
        if(c2.enabled == true && c1.enabled == true) {
            countDown.start = true;
        }
  

    }
}
