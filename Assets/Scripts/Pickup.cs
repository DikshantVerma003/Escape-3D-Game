using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject KeyOnPlayer;
    public Transform anyTF;

    //  public GameObject AxeOnPlayer;


    // Start is called before the first frame update
    void Start()
    {
        PickUpText.SetActive(false);
        KeyOnPlayer.SetActive(false);

        //        AxeOnPlayer.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                KeyOnPlayer.SetActive(true);

                PickUpText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }

    public void DropItem()
    {
        this.gameObject.SetActive(true);
        KeyOnPlayer.SetActive(false);
    }


    // not working
    // Update is called once per frame
    void Update()
    {
        // Check if the player wants to drop the item
        if (Input.GetKey(KeyCode.G))
        {
            DropItem();
        }
    }




}
