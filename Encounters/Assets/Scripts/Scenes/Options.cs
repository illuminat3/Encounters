using Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(Scenes.MainMenu);
    }
}
