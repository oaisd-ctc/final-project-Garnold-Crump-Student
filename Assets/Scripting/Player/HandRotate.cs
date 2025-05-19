using UnityEngine;

public class HeadFollower : MonoBehaviour
{
    public Transform head;
    public Transform rightHand;
    public float handOffsetY;
    public float handOffsetZ = 0.3f; // Adjust as needed for hand position
    public Transform waterCan;
    public PickUpWateringCan pickUpWateringCan;

    void Update()
    {
        if (rightHand != null)
        {
          
            Quaternion headRotation = head.transform.rotation;


          
            rightHand.rotation = headRotation;
            if (pickUpWateringCan.Pickup == true) { waterCan.rotation = headRotation; }

          
         
            rightHand.position = head.position + headRotation * new Vector3(0.1f, handOffsetY, handOffsetZ);
        }
    }
}