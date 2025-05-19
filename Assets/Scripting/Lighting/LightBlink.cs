using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlink : MonoBehaviour
{
    
    // Reference to the Light component
    private Light lightComponent;

    // Blink interval in seconds
    public float blinkInterval = 1f;

    // Blink duration (how long the light stays on or off)
    public float blinkDuration = 0.5f;

    // Boolean to track whether the light is on or off
    private bool isLightOn = true;

    // Timer to keep track of time for blinking
    private float timer = 0f;

    void Start()
    {
        // Get the Light component attached to the GameObject
        lightComponent = GetComponent<Light>();

        // Ensure the light component exists
        if (lightComponent == null)
        {
            Debug.LogError("No Light component found on this GameObject.");
        }
    }

    void Update()
    {
        if (lightComponent == null)
            return;

        // Update the timer
        timer += Time.deltaTime;

        // If the timer exceeds the blink interval, toggle the light's state
        if (timer >= blinkInterval)
        {
            isLightOn = !isLightOn;
            lightComponent.enabled = isLightOn;  // Enable or disable the light

            // Reset the timer
            timer = 0f;
        }
    }
}