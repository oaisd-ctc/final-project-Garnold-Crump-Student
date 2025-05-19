using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CornPickUp : MonoBehaviour
{
    public GameObject player;
    public GameObject corn;
    public Text text;
    public WaterdPlants waterdPlants;

  
    public Vector3 destinationPosition;
    float maxDistance = 2f;
    public int cornAmount;
    public int finalCorn;
    private bool ff;
  
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(corn);
    }

    // Update is called once per frame
    void Update()
    {
        string currnet = SceneManager.GetActiveScene().name;
        if (currnet == "Day3")
        {
            if (waterdPlants.grown == true)
            {
                Debug.Log("asdasjdaaaaaaaaaaaaaaaaaa");
                this.gameObject.SetActive(true);
                waterdPlants.grown = false;

            }
        }
      
            if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)

        if (Vector3.Distance(transform.position, player.transform.position) >= maxDistance)
        {
            text.enabled = false;
        }
            if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)

        {
            ff = true;

            text.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                corn.SetActive(false);
                cornAmount += 1;
                finalCorn += cornAmount;
                text.enabled = false;
            }
        }
        if (ff == true)
        {
            if (Vector3.Distance(transform.position, player.transform.position) > maxDistance)
            {
                text.enabled = false;
            }
        }
        if (waterdPlants.grown== true) {
            this.gameObject.SetActive(true); waterdPlants.grown = false; }
     
        }

    }
