using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public static GameManager Instance
    {
        get { return gameManager; }
    }
    
    private int currentScore = 0;
    private int highScore = 0;
    UIManager uiManager;

    public UIManager UIManager
    {
        get { return uiManager; }
    }
    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UIManager>();
        
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    
    private void Start()
    {
        uiManager.UpdateScore(0);
    }
    
    public void GameOver()
    {
        Debug.Log("Game Over");
        
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
        
        uiManager.SetRestart();
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void MainScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }
}
