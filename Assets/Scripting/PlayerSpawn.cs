using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawn : MonoBehaviour
{
    public bool startGame = true;
    public bool startGame2 = false;
    private void Update()
    {if (startGame == true)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = this.transform.position; Invoke("setFalse", 0.5f);
        }
    if(startGame2 == false)
        {
             Invoke("setFalse2", 0f);
        }
    }
    public void setFalse()
    {
        startGame = false;
    }
    public void setFalse2()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = this.transform.position;
        Invoke("settrue", 0f);
    }
    public void settrue()
    {
        startGame2 = true;
    }
}