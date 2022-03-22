using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteFIN : MonoBehaviour
{

    public void start()
    {
        GetComponent<Animator>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Animator>().enabled = false;
        }
        else if (other.tag == "PNJ_El-Professor")
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
