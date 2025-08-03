using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenuManager : MonoBehaviour
{
    [Header("Scene Names")]
    public string tutorialScene = "Tutorial";
    public string level1Scene = "Level1";
    public string level2Scene = "Level2";
    public string mainMenuScene = "MainMenu";

    public void LoadTutorial()
    {
        SceneManager.LoadScene(tutorialScene);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(level1Scene);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(level2Scene);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
