using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    public GameObject player; 
    public Vector3 destinationPosition; 
    float maxDistance = 2f;

    private void OnMouseDown()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                player.transform.position = destinationPosition;
            }
        }
        else
        {
            Debug.Log("Player GameObject not assigned!");
        }
    }
}