using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneChanger : MonoBehaviour
{
    public string sceneName; // Inspector'dan girilecek sahne ad�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Oyuncuyla temas etti�inde
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
