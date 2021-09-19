using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool active { get; set; } = true;
    public float delay;

    public void RestartGame()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex);
        active = true;
    }

    public void EndGame()
    {
        if (active == true)
        {
            Debug.Log("Game over");
            active = false;
            Invoke("RestartGame", delay);
        }
    }

}
