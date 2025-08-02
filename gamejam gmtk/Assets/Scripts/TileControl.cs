using UnityEngine;

public class TileControl : MonoBehaviour
{
    public GameObject Platform;
    public PlatformManager platformManager; 

    public float moveSpeed = 2f;
    public ButtonManager.WhatDoesButtonDo action;
    public float pressDepth = 0.3f;
    public Vector3 initialPosition;

    private bool isPressed = false;
    private void Start()
    {
        initialPosition = transform.position;
        
    }

    private void Update()
    {
        if (isPressed && Platform != null)
        {
            Vector3 direction = GetDirection(action);
            Platform.transform.position += direction * moveSpeed * Time.deltaTime;
        }
        if (isPressed && Platform != null && action == ButtonManager.WhatDoesButtonDo.Change) {
            PlatformChange();
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
    void PlatformChange()
    {
        if (platformManager != null)
        {
            platformManager.TogglePlatforms();
        }
    }

}

