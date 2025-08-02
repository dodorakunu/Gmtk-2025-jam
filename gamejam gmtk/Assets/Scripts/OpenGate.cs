using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public LandingController lControl;
    public Vector3 openOffset = new Vector3(0, 5f, 0);
    public float moveSpeed = 2f;

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
        if (lControl.allFlagsTrue)
        {
            isOpen = true;
        }
        else
        {
            isOpen = false;
        }

        Vector3 targetPosition = isOpen ? openPosition : closedPosition;

        // Hareketi yavaþça gerçekleþtir
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
    }
}
