using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game"); // "Game" scene ko load karein
        Debug.Log("Game Started");
    }
}
