using UnityEngine;

public class MovingBalls : MonoBehaviour
{
    public GameObject startPosition;
    public GameObject endPosition;
    public Rigidbody rb;
    public float rbforce = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ResetPositionAndMove();
    }

    private void FixedUpdate()
    {

        float distance = Vector3.Distance(transform.position, endPosition.transform.position);
        Vector3 rawDirection = endPosition.transform.position - transform.position;
        rawDirection.y = 0f;
        Vector3 direction = rawDirection.normalized;

        rb.AddForce(direction * rbforce);

        if (distance < 0.5f) // 
        {
            ResetPositionAndMove();
        }
    }

    void ResetPositionAndMove()
    {

        rb.isKinematic = true;
        transform.position = startPosition.transform.position;
        rb.isKinematic = false;


        Vector3 rawDirection = endPosition.transform.position - transform.position;
        rawDirection.y = 0f;
        Vector3 direction = rawDirection.normalized;

        rb.AddForce(direction * rbforce);
    }
}
