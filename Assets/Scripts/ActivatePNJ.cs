using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePNJ : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
