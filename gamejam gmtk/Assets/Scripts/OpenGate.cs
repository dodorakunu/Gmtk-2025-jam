using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public LandingController lControl;

    public Vector3 openOffset = new Vector3(0, 0.01f, 0); // Yeterli mesafe
    public float moveSpeed = 4f; // Dengeli h�z

    private Vector3 closedPosition;
    private Vector3 openPosition;

    private bool isOpen = false;

    private void Start()
    {
        closedPosition = transform.position;
        openPosition = closedPosition + openOffset;
    }

    private void Update()
    {
        isOpen = lControl.allFlagsTrue;

        Vector3 targetPosition = isOpen ? openPosition : closedPosition;

        // Yumu�ak ve dengeli ge�i�
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
