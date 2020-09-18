using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    public CanvasGroup gameOver; // stores our gameover canvas group
    public GameObject player;
    public GameObject gates;
    public CanvasGroup pauseMenu;
    private bool paused;
    public GameObject normalZombie;


    private void Start()
    {
        Time.timeScale = 1; // the game is going at normal speed
        gameOver.alpha = 0; // the game over screen is invisible
        gameOver.interactable = false; // the player is unable to interact with the game over screen
        gameOver.blocksRaycasts = false; // the game over screen does not block raycasts
        Resume();
       
    }

    public void GameOver()
    {
        Time.timeScale = 0; // freeze the game
        gameOver.alpha = 1; // the game over screen is visible
        gameOver.interactable = true; // the player can intteract with the game over screen
        gameOver.blocksRaycasts = true; // the game over screen blocks raycasts
    }
    public void Restart()
    {
        SceneManager.LoadScene(1); // the game scene is loading from the start.
        Time.timeScale = 1; // the game is going at normal speed
        player.SetActive(true);
        normalZombie.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0); // load the main menu
    }

    private void Update()
    {
        if (player == null) // if our player was destroyed...
        {
            GameOver(); // the game is over
        }

        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            Pause();
        }
        else if (paused == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }

    }

    public void Resume()
    {
        pauseMenu.alpha = 0; // the pause menu is not visible
        pauseMenu.interactable = false; // the player cannot interact with the pause menu
        pauseMenu.blocksRaycasts = false; // the pause menu does not block raycasts.
        Time.timeScale = 1; // the game is playing at normal speed
        paused = false;
        player.SetActive(true);
        normalZombie.SetActive(true);
    }
    public void Pause()
    {
        pauseMenu.alpha = 1;
        pauseMenu.interactable = true;
        pauseMenu.blocksRaycasts = true;
        Time.timeScale = 0; // the game is frozen;
        paused = true;
        player.SetActive(false);
        normalZombie.SetActive(false);



    }
}