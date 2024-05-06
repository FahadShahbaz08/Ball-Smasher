using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    public int ScoreLevel1 = 0;

    public GameObject LevelChange;
    public void GameStart()
    {
        Debug.Log("Level 1");
    }

    public void Start()
    {
            StartCoroutine(LevelChangingText(1));
    }
    public void Level1Score()
    {
        ScoreLevel1++;
        if(ScoreLevel1 >= 4)
        {
            SceneManager.LoadScene("Level 2");
        }
    }


    public IEnumerator LevelChangingText(float delay)
    {
        LevelChange.SetActive(true);
        yield return new WaitForSeconds(delay);
        LevelChange.SetActive(false);
    }

}
