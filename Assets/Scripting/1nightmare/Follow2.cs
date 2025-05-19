using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class Follow2 : MonoBehaviour
{
    public float speed = 5.0f;
    public float minDist = 1f;
    public Transform target;
    public float Damage = 0f;
    public float rotationSpeed = 5f;
    public GameObject enemy;
    public CountDown countDown;
    public GameObject player;
    public Player playerScript;
    public CountDown playerCountdown;
    void Start()
    {
        if (target == null)
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                target = player.transform;
            }
        }
    }

    void Update()
    {
        DontDestroyOnLoad(this);
        string current =SceneManager.GetActiveScene().name;
        if(current != "Day2") { this.gameObject.SetActive(false); }
        if(current == "Day2")
        {
            this.gameObject.SetActive(true);
            if (playerCountdown.chase == true)
            {
                Damage = 1f;
                if (Vector3.Distance(transform.position, player.transform.position) <= 2)
                {
                    playerScript.health -= Damage;
                    Debug.Log("-1 health");
                }
            }
        }
        if (countDown.chase == false || target == null)
            return;

        Vector3 direction = (target.position - transform.position).normalized;
        direction.y = 0f;

        
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