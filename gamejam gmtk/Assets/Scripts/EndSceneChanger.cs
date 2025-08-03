using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneChanger : MonoBehaviour
{
    public string sceneName; // Inspector'dan girilecek sahne adý

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Oyuncuyla temas ettiðinde
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
