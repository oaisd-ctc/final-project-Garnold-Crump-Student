using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public float speed = 5.0f;
    public float minDist = 1f;
    public Transform target;
    public NightmareLights nightmareLights;
    public float rotationSpeed = 5f;

    void Start()
    {
        if (target == null)
        {
            GameObject player = GameObject.FindWithTag("Hand");
            if (player != null)
            {
                target = player.transform;
            }
        }
    }

    void Update()
    {
        if (!nightmareLights || !nightmareLights.enterd || target == null)
            return;

        Vector3 direction = (target.position - transform.position).normalized;
        direction.y = 0f; // Optional: prevent vertical tilting if on a flat plane

        // Rotate smoothly toward the player
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance > minDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}