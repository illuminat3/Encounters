using Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(Scenes.LevelSelect);
    }

    public void Options()
    {
        SceneManager.LoadScene(Scenes.Options);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
