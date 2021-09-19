using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int sceneIndex;

    public void Enter()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
