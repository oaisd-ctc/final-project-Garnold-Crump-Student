using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabletMarket : MonoBehaviour
    
{
    public Image MarketButton;
    public Button Market;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) {
            MarketButton.enabled = true;
            Market.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MarketButton.enabled=false;
            Market.enabled = false;
        }
        
    }
    public void clicked()
    {
        MarketButton.enabled = false;
        Market.enabled = false;
    }
}
