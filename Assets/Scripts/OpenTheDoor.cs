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
        if (other.tag == "Player") {
            messageOpenTheDoor.SetActive(true);
        } else {
            messageOpenTheDoor.SetActive(false);
        }    
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            messageOpenTheDoor.SetActive(false);
        }
    }
    
}
