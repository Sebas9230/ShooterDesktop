using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private float gameTime = 30f;
    private bool gameEnded = false;

    void Update()
    {
        if (!gameEnded)
        {
            gameTime -= Time.deltaTime;
            if (gameTime <= 0)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        gameEnded = true;
        string result;
        if (NPCController.POINTS > 10)
        {
            result = "Victory";
            LogManager.LogEvent("Endgame", $"Result: {result}, Score: {NPCController.POINTS}");
            SceneManager.LoadScene("Win_Game");
        }
        else
        {
            result = "Defeat";
            LogManager.LogEvent("Endgame", $"Result: {result}, Score: {NPCController.POINTS}");
            SceneManager.LoadScene("End_Game");
        }
        Debug.Log($"Game Over: {result}");
    }
}

