using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject[] platforms; // Sahnedeki platformlar� buraya at

    private int activeIndex = 0;

    public void TogglePlatforms()
    {
        if (platforms.Length < 2) return;

        platforms[activeIndex].SetActive(false); // Mevcut aktifi kapat

        activeIndex = (activeIndex + 1) % platforms.Length; // S�radakini se�

        platforms[activeIndex].SetActive(true); // Yeni aktifi a�
    }
}
