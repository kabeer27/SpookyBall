using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
            instance = this;
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart()
    {
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StartSpawningPipes();
        UiManager.instance.GameStart();
    }
    public void GameOver()
    {

        gameOver = false;
        ScoreManager.instance.StopScore();
        UiManager.instance.GameOver();
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StopSpawningPipes();
    }
}
