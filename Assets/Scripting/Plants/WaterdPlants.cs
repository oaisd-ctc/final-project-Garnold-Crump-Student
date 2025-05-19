
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterdPlants : MonoBehaviour
{
    public PickUpWateringCan pickUpWateringCan;
    public ParticleSystem particle;
    public ParticleSystem waterdPlants;
    public bool waterd;
    public bool particlePlay;
    public Vector3 targetPosition;
    public float x;
    public float y;
    public float z;
    public bool grown;
    public double day2a = .5;
    public double time;
    public double time2;
 

    // Start is called before the first frame update
    void Start()
    {

        waterdPlants.Stop();



    }



    // Update is called once per frame
    void Update()
    {   string currnet = SceneManager.GetActiveScene().name;

        if (currnet == "Day2")
        {
            time += day2a * Time.deltaTime;
            if (time < 1)
            {
                if (waterd == true)
                {
                    this.transform.position = targetPosition;
                    this.transform.localScale = new Vector3(x, y, z);
                    Debug.Log("Waterd");
                    grown = true;
                    waterd = false;
                }
            }
        }
        if (currnet == "Day3")
        {
            time2 += day2a * Time.deltaTime;
            if (time2 < 1)
            {
                if (waterd == true)
                {
                    Debug.Log("msadkdo");
                    grown = true;
                    waterd = false;
                }
            }
        }



        if (waterd == false) { waterdPlants.Stop(); }
            if (pickUpWateringCan.Pickup == true)
            {
                if (Vector3.Distance(transform.position, particle.transform.position) <= 2)
                {
                    if (Input.GetMouseButton(0))
                    {
                        waterd = true;
                        waterdPlants.Play();
                        particlePlay = true;
                    }
                }

            }
         


        }
    }

        




