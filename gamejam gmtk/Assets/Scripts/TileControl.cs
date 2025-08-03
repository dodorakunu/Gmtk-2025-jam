using UnityEngine;

public class TileControl : MonoBehaviour
{
    public PlatformManager platformManager;
    public int platformIndexToControl = 0;
    public float moveSpeed = 2f;
    public ButtonManager.WhatDoesButtonDo action;
    public float pressDepth = 0.3f;
    private Vector3 initialPosition;
    private bool isPressed = false;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (isPressed && platformManager != null)
        {
            if (action != ButtonManager.WhatDoesButtonDo.Change) // Artýk C kontrolü burada deðil
            {
                GameObject platform = platformManager.GetActivePlatform();
                if (platform != null)
                {
                    Vector3 direction = GetDirection(action);
                    platform.transform.position += direction * moveSpeed * Time.deltaTime;
                }
            }
        }
    }

    private Vector3 GetDirection(ButtonManager.WhatDoesButtonDo action)
    {
        switch (action)
        {
            case ButtonManager.WhatDoesButtonDo.Forward:
                return Vector3.forward;
            case ButtonManager.WhatDoesButtonDo.Back:
                return Vector3.back;
            case ButtonManager.WhatDoesButtonDo.Left:
                return Vector3.left;
            case ButtonManager.WhatDoesButtonDo.Right:
                return Vector3.right;
            case ButtonManager.WhatDoesButtonDo.Up:
                return Vector3.up;
            case ButtonManager.WhatDoesButtonDo.Down:
                return Vector3.down;
            default:
                return Vector3.zero;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!isPressed)
        {
            isPressed = true;
            transform.position = initialPosition - new Vector3(0, pressDepth, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isPressed = false;
        transform.position = initialPosition;
    }
}



