using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{
    // Reference to the Light component (the flashlight)
    public Light flashlight;

    void Update()
    {
        // Check if the F key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();  // Toggle the flashlight state
        }
    }

    // Toggle the flashlight (turn it on or off)
    void ToggleFlashlight()
    {
        if (flashlight != null)
        {
            flashlight.enabled = !flashlight.enabled;  // Toggle the light's enabled state
        }
    }
}