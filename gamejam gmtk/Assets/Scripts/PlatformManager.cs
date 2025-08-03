using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject[] platforms;
    private int activePlatformIndex = 0;

    public GameObject GetActivePlatform()
    {
        if (platforms.Length == 0) return null;
        return platforms[activePlatformIndex];
    }

    public void TogglePlatform()
    {
        if (platforms.Length < 2) return;
        activePlatformIndex = (activePlatformIndex + 1) % platforms.Length;
    }
}
