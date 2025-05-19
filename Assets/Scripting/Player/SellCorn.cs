
using JetBrains.Annotations;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


public class SellCorn : MonoBehaviour
{
    public CornPickUp cornPickUp;
    public CornPickUp cornPickUp1;
    public CornPickUp cornPickUp2;
    public CornPickUp cornPickUp3;
    public CornPickUp cornPickUp4;
    public CornPickUp cornPickUp5;
    public CornPickUp cornPickUp6;
    public CornPickUp cornPickUp7;
    public CornPickUp cornPickUp8;
    public CornPickUp cornPickUp9;
    public CornPickUp cornPickUp10;
    public CornPickUp cornPickUp11;
    public GameObject corn1;
    public GameObject corn2;
    public GameObject corn3;
    public  double money;
    public int corn;
    public bool ontrigger;
    public Text moneyAmount;
    public Text moneyAmount1;
    public Text moneyAmount2;
    public Text moneyAmount3;
    public Text moneyAmount4;
    public bool complete2;
    public GameObject sell;
    

    
    


    // Update is called once per frame
    private void Start()
    {
        DontDestroyOnLoad(sell);
    }
    void Update()
        
    {
        moneyAmount4.text = moneyAmount.text;
        moneyAmount.text = money.ToString(); 
        moneyAmount1.text = money.ToString();
        moneyAmount2.text = money.ToString();
        moneyAmount3.text = money.ToString();

        corn = cornPickUp.cornAmount;
        corn += cornPickUp1.cornAmount;
        corn += cornPickUp2.cornAmount;
        corn += cornPickUp3.cornAmount;
        corn += cornPickUp4.cornAmount;
        corn += cornPickUp5.cornAmount;
        corn += cornPickUp6.cornAmount;
        corn += cornPickUp7.cornAmount;
        corn += cornPickUp8.cornAmount;
        corn += cornPickUp9.cornAmount;
        corn += cornPickUp10.cornAmount;
        corn += cornPickUp11.cornAmount;





        if (ontrigger == true)
        {
            corn = 0;
            cornPickUp.cornAmount = 0;
            cornPickUp1.cornAmount = 0;
            cornPickUp2.cornAmount = 0;
            cornPickUp3.cornAmount = 0;
            cornPickUp4.cornAmount = 0;
            cornPickUp5.cornAmount = 0;
           cornPickUp6.cornAmount = 0;
            cornPickUp7.cornAmount = 0;
            cornPickUp8.cornAmount = 0;
            cornPickUp9.cornAmount = 0;
             cornPickUp10.cornAmount = 0;
            cornPickUp11.cornAmount = 0;

        }
        if(ontrigger == true && corn == 0)
        {
            ontrigger = false;
           
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ontrigger = true;

        if (corn > 0)
        {
            complete2 = true;
            for (int i = 0; i <= corn -1; i++)
            {
                money += 2;



            }
          
        }
      

    }
}
