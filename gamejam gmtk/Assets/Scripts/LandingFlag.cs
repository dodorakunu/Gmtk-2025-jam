using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingFlag : MonoBehaviour
{
    public bool hasBallLanded;


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            hasBallLanded = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Ball"))
        {
            hasBallLanded = false;
        }
    }
}
