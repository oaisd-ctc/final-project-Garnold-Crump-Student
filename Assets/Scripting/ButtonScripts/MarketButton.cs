
using UnityEngine;

using UnityEngine.UI;

public class MarketButton : MonoBehaviour
{
    public RawImage tablet;
    public Image button;
    public Text market;
    public RawImage tabletMarket;
    public Image StamButton;
    public Text stam;
    public Text money;
    public Image button2;
    public Text Purchase2;
   
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if(tabletMarket.enabled == true) { money.enabled = true; StamButton.enabled = true; stam.enabled = true; }
        if(tabletMarket.enabled == false) { money.enabled = false; stam.enabled = false; StamButton.enabled = false; button2.enabled = false; Purchase2.enabled = false; }
        if (Input.GetKeyDown(KeyCode.Q)){
            tabletMarket.enabled = false;
        }
       
        }





    
   public void Click()
    {
        
        tablet.enabled = false;
        button.enabled = false;
        market.enabled = false;
        tabletMarket.enabled = true;
        StamButton.enabled = true;
        stam.enabled = true;
   

        
    }
}
