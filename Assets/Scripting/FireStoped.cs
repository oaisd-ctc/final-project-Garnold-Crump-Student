using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireStoped : MonoBehaviour
{
    public ParticleSystem particle;
    private void Update()
    {
        if(particle.isEmitting == true)
        {
            Debug.Log("Stopped");
        }
    }
}