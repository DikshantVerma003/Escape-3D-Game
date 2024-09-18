using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showtext : MonoBehaviour
{
    public GameObject Text; // Reference to the text GameObject

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the text is not visible at the start
        Text.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            // Make the text visible
            Text.SetActive(true);
        }
    }

   /* private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            // Make the text invisible
            Text.SetActive(false);
        }
    }*/

    private void OnTriggerExit(Collider other)
    {
            // Make the text invisible
            Text.SetActive(false);
    
    }
}
