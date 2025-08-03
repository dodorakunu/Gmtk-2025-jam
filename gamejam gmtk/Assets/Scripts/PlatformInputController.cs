using UnityEngine;

public class PlatformInputController : MonoBehaviour
{
    public PlatformManager platformManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            platformManager.TogglePlatform();
        }
    }
}

