using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void OnEnable()
    {
        EventManager.Clicked += PlayGame;
    }

    void OnDisable()
    {
        EventManager.Clicked -= PlayGame;

    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
