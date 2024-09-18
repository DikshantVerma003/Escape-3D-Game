using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public Light myLight; // Assign the light you want to control in the inspector
    private float timeSinceTurnedOn = 0.0f; // Track time since light was turned on

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            myLight.enabled = true; // Turn light on
            timeSinceTurnedOn = Time.time; // Reset timer when light is turned on
        }

        if (myLight.enabled && Time.time - timeSinceTurnedOn > 20.0f) // Check if light is on and timer elapsed
        {
            myLight.enabled = false; // Turn light off after 20 seconds
        }
    }


}
