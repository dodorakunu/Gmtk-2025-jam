using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBalls : MonoBehaviour
{
    public GameObject StartBall;
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.isKinematic = false;
        other.transform.position = StartBall.transform.position;
        other.attachedRigidbody.isKinematic = true;
        Vector3 rawDirection = transform.position - other.transform.position;
        rawDirection.y = 0f;
        Vector3 direction = rawDirection.normalized;

        other.attachedRigidbody.AddForce(direction * 5f);
    }
}
