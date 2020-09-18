using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenuController : MonoBehaviour

{
    public CanvasGroup mainMenu; // stores a refrence to the main menu
    public CanvasGroup optionsMenu; // stores a refrence to the options menu
    public CanvasGroup creditsMenu; // stores a refrence to the credits menu

    public void Start()
    {
        mainMenu.alpha = 1;
        mainMenu.interactable = true;
        mainMenu.blocksRaycasts = true;                        // ensures the main menu will appear on startup
        optionsMenu.alpha = 0;
        optionsMenu.interactable = false;
        optionsMenu.blocksRaycasts = false;
        creditsMenu.alpha = 0;
        creditsMenu.interactable = false;
        creditsMenu.blocksRaycasts = false;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1); // loads the game scene
    }
    // loads the options menu
    public void OptionsMenu()
    {
        mainMenu.alpha = 0;
        mainMenu.interactable = false;
        mainMenu.blocksRaycasts = false;
        optionsMenu.alpha = 1;
        optionsMenu.interactable = true;
        optionsMenu.blocksRaycasts = true;
        creditsMenu.alpha = 0;
        creditsMenu.interactable = false;
        creditsMenu.blocksRaycasts = false;
    }
    // load credits menu
    public void CreditsMenu()
    {
        mainMenu.alpha = 0;
        mainMenu.interactable = false;
        mainMenu.blocksRaycasts = false;
        optionsMenu.alpha = 0;
        optionsMenu.interactable = false;
        optionsMenu.blocksRaycasts = false;
        creditsMenu.alpha = 1;
        creditsMenu.interactable = true;
        creditsMenu.blocksRaycasts = true;

    }
    // quit the game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }

    public void Back()
    {
        mainMenu.alpha = 1;
        mainMenu.interactable = true;
        mainMenu.blocksRaycasts = true;
        optionsMenu.alpha = 0;
        optionsMenu.interactable = false;
        optionsMenu.blocksRaycasts = false;
        creditsMenu.alpha = 0;
        creditsMenu.interactable = false;
        creditsMenu.blocksRaycasts = false;
    }


}