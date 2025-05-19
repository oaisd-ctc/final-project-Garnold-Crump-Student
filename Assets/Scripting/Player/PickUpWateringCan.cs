
using UnityEngine;
using UnityEngine.UI;

public class PickUpWateringCan : MonoBehaviour
{
    public GameObject player;
    public GameObject PickUpObject;
    public GameObject Hands;
    public float maxDistance = 4;
    public Text text;
    public bool Pickup;
    private Rigidbody rb;

    public Transform head;
    public Transform rightHand;
    public float handOffsetY;
    public float handOffsetZ = 0.3f;

    public ParticleSystem particle;
  

    // Start is called before the first frame update
    void Start()
    {
        particle.Stop();
        DontDestroyOnLoad(PickUpObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) >= maxDistance)

        {
            text.enabled = false;
        }
        if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)

        { text.enabled = false; }
            if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)

        {
          
            text.enabled = true;
          
            if (Input.GetKeyDown(KeyCode.E))
            {
                Pickup = true;
                text.enabled = false;
                
             PickUpObject.GetComponent<Rigidbody>().isKinematic = true;
                PickUpObject.transform.position = Hands.transform.position;
                PickUpObject.transform.parent = Hands.transform;
                PickUpObject.transform.eulerAngles = Hands.transform.eulerAngles;
                Quaternion headRotation = head.transform.rotation;



                rightHand.rotation = headRotation;



                rightHand.position = head.position + headRotation * new Vector3(0.1f, handOffsetY, handOffsetZ);



            }
            if(Pickup == true)
            {
              
                text.enabled=false;
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    PickUpObject.GetComponent<Rigidbody>().isKinematic = false;
                    PickUpObject.transform.parent = null;
                    text.enabled = true;
                    Pickup = false;
                   
                }

               

                if (Input.GetMouseButtonDown(0)) { particle.Play(); }
                if (Input.GetMouseButtonUp(0)) { particle.Stop(); }

            }
        }
    }
}
