using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCanSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public bool startGame = true;
    private void Update()
    {
        if (startGame == true)
        {
            GameObject player = GameObject.FindGameObjectWithTag("WcanSpawn");
            player.transform.position = this.transform.position; Invoke("setFalse", 0.5f);
        }
    }
    public void setFalse()
    {
        startGame = false;
    }

}
