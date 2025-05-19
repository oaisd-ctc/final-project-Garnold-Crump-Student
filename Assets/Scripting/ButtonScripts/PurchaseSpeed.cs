
using UnityEngine;
using UnityEngine.UI;



public class PurchaseSpeed : MonoBehaviour
{
    public SellCorn sellCorn;
    public bool Purhcased1;
    public Player player;
    public Image button;
    public Text buttontext;
    public Button buttons;
    public bool click;
    public bool click2;
    public bool click3;
    public Button DifferentButton;
    public Text buttontext2;
    public Image button2;
    public Button differentButton2;
    public Image buttonimg;
    public Text buttonimgtext;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (click == true)
        {
            buttons.enabled = false; button.enabled = false;
            buttontext.enabled = false;
        }
        if (click2 == true)
        {
            DifferentButton.enabled = false; buttontext2.enabled = false;
            button2.enabled = false;
        }
        if(click3 == true)
        {
            differentButton2.enabled = false;
            buttonimg.enabled = false;
            buttonimgtext.enabled = false;
        }
    }
    public void Click()
    {
        if (sellCorn.money >= 5)
        {
            sellCorn.money -= 5;
            Purhcased1 = true;
            button.enabled = false;
            buttontext.enabled = false;
         
            buttons.enabled = false;
        

            click = true;
            player.moveSpeed = 4;
            player.sprintSpeed = 9;
            DifferentButton.enabled = true;
            buttontext2.enabled = true;
            button2.enabled = true;



        }


    }
    public void Click2()
    {
        if (sellCorn.money >= 5)
        {

            sellCorn.money -= 5;

            DifferentButton.enabled = false;
            buttontext2.enabled = false;
            button2.enabled = false;
            click2 = true;
            player.moveSpeed = 5;
            player.sprintSpeed = 10;
            differentButton2.enabled = true;
            buttonimg.enabled = true;
            buttonimgtext.enabled = true;
        }
    }
    public void Click3()
    {
        if (sellCorn.money >= 5)
        {
            sellCorn.money -= 5;
            differentButton2.enabled = false;
            buttonimg.enabled = false;
            buttonimgtext.enabled = false;
            click3 = true;
            player.moveSpeed = 6;
            player.sprintSpeed = 11;
        }
    }
}
