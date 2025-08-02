using UnityEngine;

public class MovingBalls : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;
    public float rbforce = 5f;
    public float teleportDistance = 0.5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ResetPosition();
        ApplyForceTowardEnd();
    }

    void FixedUpdate()
    {
        Vector3 toEnd = endPosition.position - transform.position;
        toEnd.y = 0f;

        rb.AddForce(toEnd.normalized * rbforce);

        if (toEnd.magnitude < teleportDistance)
        {
            TeleportToStart();
        }
    }

    void TeleportToStart()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = startPosition.position;
    }

    void ResetPosition()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = startPosition.position;
    }

    void ApplyForceTowardEnd()
    {
        Vector3 dir = (endPosition.position - transform.position);
        dir.y = 0f;
        rb.AddForce(dir.normalized * rbforce, ForceMode.Impulse);
    }
}

