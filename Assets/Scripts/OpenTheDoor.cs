using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenTheDoor : MonoBehaviour
{

    public GameObject messageOpenTheDoor;

    void Start()
    {
        // messageOpenTheDoor.SetActive(false);   
    }

    private void OnTriggerEnter(Collider other) {
            
        if (other.tag == "PNJ_El-Professor") 
        {
            Debug.Log("El Professor is enter in the door");
            messageOpenTheDoor.SetActive(false);
        }

        if (other.tag == "Player")
        {
            Debug.Log("Player");
            messageOpenTheDoor.SetActive(true);
        }

        else
        {
            Debug.Log("Else");
            messageOpenTheDoor.SetActive(false);

        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            messageOpenTheDoor.SetActive(false);
        }
    }
    
}
