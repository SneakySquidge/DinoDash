using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject WinGame;
    public DinoScript dino;


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

    public void WinScreen()
    {
        WinGame.SetActive(true);
        dino.DinoIsAlive = false;
        
    }

    
}
