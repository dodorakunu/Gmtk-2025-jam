using UnityEngine;

public class ButtonInside : MonoBehaviour
{
    public bool isPressed = false;
    public float pressDepth = 0.1f;
    private Vector3 initialPosition;
    private ButtonWork buttonWork;

    private void Start()
    {
        initialPosition = transform.position;
        buttonWork = GetComponent<ButtonWork>(); // Ayný objede ButtonWork scripti varsa bulur
    }

    private void OnTriggerStay(Collider other)
    {
        if (!isPressed)
        {
            isPressed = true;
            transform.position = initialPosition - new Vector3(0, pressDepth, 0);

            if (buttonWork != null)
            {
                buttonWork.MovePlatform(); // BUTONA BASILDIÐINDA PLATFORM HAREKET EDER
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isPressed = false;
        transform.position = initialPosition;
    }
}
