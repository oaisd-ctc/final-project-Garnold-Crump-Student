using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Tablet : MonoBehaviour
{
    public GameObject player;
    public GameObject PickUpObject;
    public GameObject Hands;
    public float maxDistance = 4;
    public bool Pickup;
    private Rigidbody rb;

    public Transform head;
    public Transform rightHand;
    public float handOffsetY;
    public float handOffsetZ = 0.3f;
    public RawImage tablet;
    public Image market;
    public Text marketPlace;
    



    // Start is called before the first frame update
    void Start()
    {
      DontDestroyOnLoad(PickUpObject);
    }

    // Update is called once per frame
    void Update()
    {
     

          

            if (Input.GetKeyDown(KeyCode.T))
            {
                Pickup = true;
             

                PickUpObject.GetComponent<Rigidbody>().isKinematic = true;
                PickUpObject.transform.position = Hands.transform.position;
                PickUpObject.transform.parent = Hands.transform;
                PickUpObject.transform.eulerAngles = Hands.transform.eulerAngles;
                Quaternion headRotation = head.transform.rotation;
                tablet.enabled = true;
            market.enabled = true;
            marketPlace.enabled = true;


                rightHand.rotation = headRotation;



                rightHand.position = head.position + headRotation * new Vector3(0.1f, handOffsetY, handOffsetZ);

            Cursor.lockState = CursorLockMode.None;

            }
            if (Pickup == true)
            {

             
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    PickUpObject.GetComponent<Rigidbody>().isKinematic = false;
                    PickUpObject.transform.parent = null;
                   
                    Pickup = false;
                tablet.enabled = false;
                market.enabled = false;
                marketPlace.enabled = false;
                Cursor.lockState = CursorLockMode.Locked;

            }



            

            }
        }
    }



