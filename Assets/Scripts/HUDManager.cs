using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class HUDManager : MonoBehaviour
{
    public Text highScoreText;

    void Awake()
    {
        ShowHighScore();
    }

    public void ShowHighScore()
    {
        string username = GameManager.gameManager.highUser;
        string score = GameManager.gameManager.highScore.ToString();
        string updateText = ($"High Score: {username}: {score}");
        highScoreText.text = updateText;
    }
}
