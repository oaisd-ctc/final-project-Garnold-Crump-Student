using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlantsGrow : MonoBehaviour
{
    
    public bool t;
    public WaterdPlants[] waterdPlants;
    public float num = 0;
    public WaterdPlants waterdPlant;
    public WaterdPlants WaterdPlant2; 
    public WaterdPlants waterdPlant3;
    public WaterdPlants waterdPlant4;
    public WaterdPlants waterdPlant5;
    public WaterdPlants waterdPlant6;
    public WaterdPlants waterdPlant7;
    public WaterdPlants waterdPlant8;
    public WaterdPlants waterdPlant9;
    public WaterdPlants waterdPlant10;
    public WaterdPlants waterdPlant11;
    public WaterdPlants waterdPlant12;
    public WaterdPlants waterdPlant13;
    public WaterdPlants waterdPlant14;
    public WaterdPlants waterdPlant15;
    public WaterdPlants waterdPlant16;
    public WaterdPlants waterdPlant17;
    public WaterdPlants waterdPlant18;
    public WaterdPlants waterdPlant19;
    public WaterdPlants waterdPlant20;
    public WaterdPlants waterdPlant21;
    public WaterdPlants waterdPlant22;
    public WaterdPlants waterdPlant23;
    public WaterdPlants waterdPlant24;
    public WaterdPlants waterdPlant25;
    public WaterdPlants waterdPlant26;
    public WaterdPlants waterdPlant27;
    public WaterdPlants waterdPlant28;
    public WaterdPlants waterdPlant29;
    public WaterdPlants waterdPlant30;
    public WaterdPlants waterdPlant31;
    public WaterdPlants waterdPlant32;
    public WaterdPlants waterdPlant33;
    public WaterdPlants waterdPlant34;
    public WaterdPlants waterdPlant35;
    public WaterdPlants waterdPlant36;
    public WaterdPlants waterdPlant37;
    public WaterdPlants waterdPlant38;
    public WaterdPlants waterdPlant39;
    public WaterdPlants waterdPlant40;
    public WaterdPlants waterdPlant41;
    public WaterdPlants waterdPlant42;
    public WaterdPlants waterdPlant43;
    public WaterdPlants waterdPlant44;
    public WaterdPlants waterdPlant45;
    public WaterdPlants waterdPlant46;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        DontDestroyOnLoad(this);
        string currnet = SceneManager.GetActiveScene().name;
        if(currnet == "Day2")
        {
            this.gameObject.SetActive(true);
           foreach(var plant in waterdPlants)
            {
                if(waterdPlant.waterd == true && WaterdPlant2.waterd == true  
&& waterdPlant3.waterd == true
&& waterdPlant4.waterd == true
&& waterdPlant5.waterd == true
&& waterdPlant6.waterd == true
&& waterdPlant7.waterd == true
&& waterdPlant8.waterd == true
&& waterdPlant9.waterd == true
&& waterdPlant10.waterd == true
&& waterdPlant11.waterd == true
&& waterdPlant12.waterd == true
&& waterdPlant13.waterd == true
&& waterdPlant14.waterd == true
&& waterdPlant15.waterd == true
&& waterdPlant16.waterd == true
&& waterdPlant17.waterd == true
&& waterdPlant18.waterd == true
&& waterdPlant19.waterd == true
&& waterdPlant20.waterd == true
&& waterdPlant21.waterd == true
&& waterdPlant22.waterd == true
&& waterdPlant23.waterd == true
&& waterdPlant24.waterd == true
&& waterdPlant25.waterd == true
&& waterdPlant26.waterd == true
&& waterdPlant27.waterd == true
&& waterdPlant28.waterd == true
&& waterdPlant29.waterd == true
&& waterdPlant30.waterd == true
&& waterdPlant31.waterd == true
&& waterdPlant32.waterd == true
&& waterdPlant33.waterd == true
&& waterdPlant34.waterd == true
&& waterdPlant35.waterd == true
&& waterdPlant36.waterd == true
&& waterdPlant37.waterd == true
&& waterdPlant38.waterd == true
&& waterdPlant39.waterd == true
&& waterdPlant40.waterd == true
&& waterdPlant41.waterd == true
&& waterdPlant42.waterd == true
&& waterdPlant43.waterd == true
&& waterdPlant44.waterd == true
&& waterdPlant45.waterd == true
&& waterdPlant46.waterd == true)
                {
                    num += 1;
                }
            }
        }
        if(num > 0)
        {
            
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Debug.Log("asdad");
                t = true;
            }
            if(Input.GetKeyDown(KeyCode.Escape)) {
                t = false;
            } 
        }
    }
}
