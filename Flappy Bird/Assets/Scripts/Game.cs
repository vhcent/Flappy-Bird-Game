using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverCanvas;
    public GameObject titleScreenCanvas;
    public Bird bird;

    private void Start() {
        {
            gameOverCanvas.SetActive(false);
            titleScreenCanvas.SetActive(true);
            Time.timeScale = 1;
        }
    }

    private void Update() 
    {
        if (bird.state == Bird.State.running)
        {
            titleScreenCanvas.SetActive(false);
        }
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
