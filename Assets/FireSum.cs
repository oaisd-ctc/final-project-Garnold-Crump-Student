using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireSum : MonoBehaviour
{
    
    public FireOut[] fireStoped;
    public FireOut fireOut1;
    public FireOut fireOut2;
    public FireOut fireOut3;
    public FireOut fireOut4;
    public FireOut fireOut5;    
    public FireOut fireOut6;
    public FireOut fireOut7;
    public FireOut fireOut8;
    public FireOut fireOut9;
    public FireOut fireOut10;
    public FireOut fireOut11;
    public FireOut fireOut12;
    public FireOut fireOut13;     
    public FireOut fireOut14;
    public FireOut fireOut15;
    public FireOut fireOut16;
    public FireOut fireOut17;
    public FireOut fireOut18;   
public FireOut fireOut19;
    public FireOut fireOut20;
    public FireOut fireOut21;
    public FireOut fireOut22;
    public FireOut fireOut23;
    public FireOut fireOut24;       
    public FireOut fireOut25;
    public FireOut fireOut26;       
    public FireOut fireOut27;
    public FireOut fireOut28;
    public FireOut fireOut29;
    public FireOut fireOut30;
    public FireOut fireOut31;
    public FireOut fireOut32;
        public FireOut fireOut33;
    public FireOut fireOut34;
    public FireOut fireOut35;
    public FireOut fireOut36;
        public FireOut fireOut37;
    public float num = 0;
    public OnLeaveStartTime onLeaveStartTime;
    public GameObject ufo;
    public GameObject enemy;
    public Vector3 enemyUfo;
    public Vector3 playersArea;
 
    public GameObject UFoParent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
          if(   fireOut1.stoped == true && 
             fireOut2.stoped == true &&
             fireOut3.stoped == true && 
             fireOut4.stoped == true &&
             fireOut5.stoped == true && 
             fireOut6.stoped == true &&
             fireOut7.stoped == true && 
             fireOut8.stoped == true &&
             fireOut9.stoped == true && 
             fireOut10.stoped == true && 
             fireOut11.stoped == true && 
             fireOut12.stoped == true && 
             fireOut13.stoped == true && 
             fireOut14.stoped == true && 
             fireOut15.stoped == true && 
             fireOut16.stoped == true && 
             fireOut17.stoped == true && 
             fireOut18.stoped == true && 
             fireOut19.stoped == true && 
             fireOut20.stoped == true && 
             fireOut21.stoped == true && 
             fireOut22.stoped == true && 
             fireOut23.stoped == true && 
             fireOut24.stoped == true && 
             fireOut25.stoped == true && 
             fireOut26.stoped == true && 
             fireOut27.stoped == true && 
             fireOut28.stoped == true && 
             fireOut29.stoped == true && 
             fireOut30.stoped == true && 
             fireOut31.stoped == true && 
             fireOut32.stoped == true && 
             fireOut33.stoped == true && 
             fireOut34.stoped == true && 
        fireOut35.stoped == true &&
             fireOut36.stoped == true && 
             fireOut37.stoped == true ) 
        {

            if(onLeaveStartTime.time > 0)

            {
                Vector3 diretction = enemy.transform.position;
ufo.SetActive(true);
                enemy.SetActive(true);
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                player.transform.position = playersArea;
                if (enemy.transform.position.y < 18)
                {
                    enemy.transform.Translate(Vector3.up * 5 * Time.deltaTime);
                    Invoke("UfoTravel", 3.5f);
                    Invoke("WinningScene", 4.5f);

                }
               

            }
        
        
        }
        else {if (onLeaveStartTime.time <= 0)
            {
                SceneManager.LoadScene("Lost");
            }
        }
          

        
     
    }
  public  void UfoTravel()
    {
        UFoParent.transform.Translate(Vector3.back * 10 * Time.deltaTime);
    }
    public void WinningScene()
    {
        SceneManager.LoadScene("Won");
    }

}
