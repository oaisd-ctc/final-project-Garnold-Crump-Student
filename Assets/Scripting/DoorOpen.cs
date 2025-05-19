using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
    public float rotationSpeed = 90f;  // Degrees per second the door will rotate
    public float openAngle = 90f;     // The angle the door will rotate to when opened
    public float closedAngle = 0f;    // The angle the door will rotate to when closed
    public KeyCode openCloseKey = KeyCode.E;  // The key to press to open and close the door
    public Vector3 uau;
    private bool isOpening = false;   // Flag to determine if the door should be opening
    private bool isClosed = true;     // Flag to check if the door is closed
    public MeshRenderer wall1;
    public MeshRenderer wall2;
    private float maxDistance = 2f;
    public GameObject player;
    public GameObject Door;
  public GameObject w1;
    public GameObject w2;
     void Start()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(w1); DontDestroyOnLoad(w2);


    }
    void Update()
    {
      
           
        
        string current = SceneManager.GetActiveScene().name;
        
        if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance) {
            if (Input.GetKeyDown(openCloseKey))
            {
                isOpening = !isOpening;  // Toggle between opening and closing
                isClosed = !isClosed;    // Toggle the closed state
            }
        }
        // Rotate the door based on the current state
        if (isOpening)
        {
            // Rotate towards the open position (openAngle)
            float targetAngle = openAngle;
            RotateDoor(targetAngle);
            wall1.enabled = true; wall2.enabled = true;
       
        }
        else if (isClosed)
        {
            // Rotate back to the closed position (closedAngle)
            float targetAngle = closedAngle;
            RotateDoor(targetAngle);
            wall1.enabled = false; wall2.enabled = false;


        }
        else
        {
            wall2 = null;
            wall1 = null;
        }
    }

    void RotateDoor(float targetAngle)
    {
        // Get the current rotation of the door
        float currentAngle = transform.eulerAngles.z;

        // Calculate the direction to rotate (clockwise or counterclockwise)
        float angleToRotate = Mathf.MoveTowardsAngle(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);

        // Apply the rotation on the Y-axis (assuming door rotates around the Y-axis)
        transform.rotation = Quaternion.Euler(-87.87f, 1.19f,angleToRotate);

       
    }
}

