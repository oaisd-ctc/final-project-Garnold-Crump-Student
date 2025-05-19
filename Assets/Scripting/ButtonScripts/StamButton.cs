using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StamButton : MonoBehaviour
{
    public Image Satmv1;
    public Image Box;
    public Image buttonPurchase;
    public Text purchase;
    public Image StickFigure;
    public Button Purchase;
    public Text StickText;
    public Text StickDescripton;
    public RawImage marketButton;
    public bool clicked;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (marketButton.enabled == false)
        {
            StickDescripton.enabled = false;
            StickText.enabled = false;
            StickFigure.enabled = false;
            Box.enabled = false;
            Satmv1.enabled = false;
            Purchase.enabled = false;
            purchase.enabled = false;
            buttonPurchase.enabled = false;
        } 
    }
    public void Click()
    {
        Satmv1.enabled = true;
        Box.enabled = true;
        StickFigure.enabled = true;
        Purchase.enabled = true;
        buttonPurchase.enabled = true;
        purchase.enabled = true;
        StickText.enabled = true;
        StickDescripton.enabled = true;
        clicked = true;
        Invoke("False", 0f);
        
        
    }
    void False(){clicked = false;}

}
