using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject gameOverPanel;
    public GameObject startUI;
    // Start is called before the first frame update
    public Text scoreText;
    public Text highScoreText;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString(); 
    }
    public void GameStart()
    {
        startUI.SetActive(false);
    }

    public void GameOver()
    {
        highScoreText.text = "HighScore: "+PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
    }
    public void Replay()
    {
        SceneManager.LoadScene("level1");
 
        
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
