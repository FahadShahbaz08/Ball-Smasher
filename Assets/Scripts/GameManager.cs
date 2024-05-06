using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject displayScreen;

    public int PlayerScore = 0;


    public void ScoreUp()
    {
        PlayerScore ++;
        if(PlayerScore >= 6)
        {
            SceneManager.LoadScene("Level 1");
            print("level 1 is loaded");
        }
    }


    
    public void GameStart()
    {

        displayScreen.SetActive(false);
        Debug.Log("game started");

    }
}
