using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public GameObject disappearObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Reference to the object with the Disappear script attached


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && disappearObject.activeSelf)
        {
            // Make the object disappear when the player enters the trigger area
            disappearObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }


}
