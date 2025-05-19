using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpeedButton : MonoBehaviour
{
    public Image SpeedUpgrades;
    public Image buttonPurchase;
    public Text purchase;
    public Button Purchase;
    public Text SpeedText;
    public Text SpeedDescripton;
    public RawImage marketButton;
    public Image button;
    public Text buttontxt;
    public Button button2;
    public Image box;
    public Image stick;
    public Image purchase1;
    public Image purchase2;
    public Text textpurchase1;
    public Text textpurchase2;
    public Button puchases1;
    public Button puchases2;
    public PurhcaseButton purchaseButton;
    public StamButton stamButton;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(purchaseButton.click3 == true)
        {
            puchases2.enabled = false;
            purchase2.enabled = false;

        }
        if(stamButton.clicked == true)
        {
            SpeedUpgrades.enabled = false;
            Purchase.enabled = false;
            buttonPurchase.enabled = false;
            purchase.enabled = false;
            SpeedText.enabled = false;
            SpeedDescripton.enabled = false;

            box.enabled = false;
            stick.enabled = false;
        }
        if (marketButton.enabled == false)
        {
            SpeedDescripton.enabled = false;
            SpeedText.enabled = false;
            SpeedUpgrades.enabled = false;
            Purchase.enabled = false;
            purchase.enabled = false;
            buttonPurchase.enabled = false;
            button.enabled = false;
            button2.enabled = false;
            buttontxt.enabled = false;
            box.enabled = false;
            stick.enabled = false;
            purchase1.enabled = false;
            purchase2.enabled = false;
            textpurchase1.enabled = false; textpurchase2.enabled = false;
            puchases1.enabled = false;
            puchases2.enabled = false;
            
        }
        if(marketButton.enabled == true)
        {
            button.enabled = true;
            button2.enabled = true;  buttontxt.enabled = true;

          
        }
    }
    public void OnClick() {

        SpeedUpgrades.enabled = true;
        Purchase.enabled = true;
        buttonPurchase.enabled = true;
        purchase.enabled = true;
        SpeedText.enabled = true;
        SpeedDescripton.enabled = true;
       
        box.enabled = true;
        stick.enabled = true;
        if (purchaseButton.click == false && purchaseButton.click2 == false && purchaseButton.click3 == false) { purchase1.enabled = true;
            purchase2.enabled = true;
            textpurchase1.enabled = true; textpurchase2.enabled = true;
            puchases1.enabled = true;
            puchases2.enabled = true;
            purchase.enabled = true;
        }
        if (purchaseButton.click == true &&  purchaseButton.click2 == true && purchaseButton.click3 == true) {  purchase1.enabled = false;  purchase2.enabled = false;  purchase.enabled = true; }
    }
}
