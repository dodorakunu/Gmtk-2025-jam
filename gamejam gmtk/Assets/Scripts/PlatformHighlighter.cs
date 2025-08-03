using UnityEngine;

public class PlatformHighlighter : MonoBehaviour
{
    public PlatformManager platformManager;
    public GameObject highlightBox;
    public Vector3 offset = new Vector3(0, 0.1f, 0);

    private bool highlightEnabled = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            highlightEnabled = !highlightEnabled;
        }

        if (!highlightEnabled || platformManager == null || highlightBox == null)
        {
            if (highlightBox != null) highlightBox.SetActive(false);
            return;
        }

        GameObject activePlatform = platformManager.GetActivePlatform();
        if (activePlatform != null)
        {
            highlightBox.SetActive(true);
            highlightBox.transform.position = activePlatform.transform.position + offset;

            Renderer rend = activePlatform.GetComponentInChildren<Renderer>();
        }
        else
        {
            highlightBox.SetActive(false);
        }
    }
}

