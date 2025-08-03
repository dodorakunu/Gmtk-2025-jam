using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Assign these from the Inspector
    public string gameSceneName = "GameScene";
    public string levelSelectSceneName = "LevelSelectScene";

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void OpenLevelSelect()
    {
        SceneManager.LoadScene(levelSelectSceneName);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
