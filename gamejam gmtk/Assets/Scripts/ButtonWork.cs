using Unity.VisualScripting;
using UnityEngine;

public class ButtonWork : MonoBehaviour
{
    
    public GameObject Platform;
    public ButtonManager.WhatDoesButtonDo action;  // Enum'u ButtonManager'dan çekiyoruz

    public void MovePlatform()
    {
        switch (action)
        {
            case ButtonManager.WhatDoesButtonDo.Forward:
                Platform.transform.position += Vector3.forward * 2f;
                break;

            case ButtonManager.WhatDoesButtonDo.Back:
                Platform.transform.position += Vector3.back * 2f;
                break;

            case ButtonManager.WhatDoesButtonDo.Left:
                Platform.transform.position += Vector3.left * 2f;
                break;

            case ButtonManager.WhatDoesButtonDo.Right:
                Platform.transform.position += Vector3.right * 2f;
                break;

            case ButtonManager.WhatDoesButtonDo.Up:
                Platform.transform.position += Vector3.up * 2f;
                break;

            case ButtonManager.WhatDoesButtonDo.Down:
                Platform.transform.position += Vector3.down * 2f;
                break;

            case ButtonManager.WhatDoesButtonDo.Change:
                Platform.SetActive(!Platform.activeSelf);
                break;
        }
    }
}

