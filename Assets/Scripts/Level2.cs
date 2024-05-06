using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public int ScoreLevel2 = 0;
    public GameObject winText;
    public GameObject restartButton;
    public GameObject Level2text;

    private void Start()
    {
        print("Level 2 start");
        StartCoroutine(Level2ChangingText(1));
    }
    public void Level2Score()
    {
        ScoreLevel2++;
        if(ScoreLevel2 >= 5)
        {
            Win();
        }    
    }
    public void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    IEnumerator Level2ChangingText(float delay)
    {
        Level2text.SetActive(true);
        yield return new WaitForSeconds(delay);
        Level2text.SetActive(false);
    }
}
