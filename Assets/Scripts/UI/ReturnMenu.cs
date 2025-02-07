using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{

    void OnEnable()
    {
        EventManager.Clicked += Return;
    }

    void OnDisable()
    {
        EventManager.Clicked -= Return;

    }

    public void Return()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
