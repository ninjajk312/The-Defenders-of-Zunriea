using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{

    public void LevelOne()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
