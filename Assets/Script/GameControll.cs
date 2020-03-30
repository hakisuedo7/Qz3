using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControll : MonoBehaviour
{
    [SerializeField] private GameObject GameOverView;
    [SerializeField] private GameObject GameCompleteView;
    private static bool gameIsOver = false;
    // Start is called before the first frame update
    void Start()
    {
        GameOverView.SetActive(false);
        GameCompleteView.SetActive(false);
        gameIsOver = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameComplete()
    {
        GameCompleteView.SetActive(true);
        gameIsOver = true;
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        GameOverView.SetActive(true);
        gameIsOver = true;
        Time.timeScale = 0f;
    }

    public bool isGameOver()
    {
        return gameIsOver;
    }
}
