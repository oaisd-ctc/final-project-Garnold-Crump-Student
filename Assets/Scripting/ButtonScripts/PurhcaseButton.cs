using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PurhcaseButton : MonoBehaviour
{
    public SellCorn sellCorn;
    public bool Sold;
    public bool sold2;
    public Player player;
    public float Stamv1 = 7;
    public Image button;
    public Text buttontext;
    public Image button2;
    public Text buttontext2;
    public Button buttons;
    public Button buttons2;
    public Button DifferentButton;
    public bool sold3;
    public Button button3;
    public Image buttonimg;
    public Text buttonimgtext;
    public Button differentButton2;
    public bool click;
    public bool click2;
    public bool click3;
    public float fix;
   
    public bool CurrentSprintLength { get; set; }
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
        if(click == false && click2 == false && click3 == false) { fix = 5; }
       if (click == true) { buttons.enabled = false; button.enabled = false;
            buttontext.enabled = false; fix = 7;
        }
       if(click2 == true) { DifferentButton.enabled = false; buttontext2.enabled = false;
            button2.enabled = false; fix = 9;
        }
       if (click3 == true) { differentButton2.enabled = false; buttonimg.enabled = false;
            buttonimgtext.enabled = false; fix = 10;
        }
    }
    public void Click()
    {
        if(sellCorn.money >= 5)
        {
            sellCorn.money -= 5;
            Sold = true;
            button.enabled = false;
            buttontext.enabled = false;
            button2.enabled = true;
            buttontext2.enabled = true;
            button2.enabled = true;
            buttons.enabled = false;
            DifferentButton.enabled = true;
            
           click=true;

          
            
        }
       
      
    }
    public void Click2()
    {
            if (sellCorn.money >= 5)
            {

                sellCorn.money -= 5;
                Sold = false;
                sold2 = true;
               
                DifferentButton.enabled = false;
            buttontext2.enabled= false;
            button2.enabled= false;
            button3.enabled = true;
            buttonimg.enabled = true;
            buttonimgtext.enabled = true;
            click2 =true;
            }
        }
    public void Click3()
    {
        if (sellCorn.money >= 5)
        {
            sellCorn.money -= 5;
            sold3 = true;
            sold2 = false;
            button3.enabled= false;
            differentButton2.enabled= false;
            buttonimg.enabled = false;
            buttonimgtext.enabled = false;
            click3 = true;

        }
    }
    }

 
