using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}