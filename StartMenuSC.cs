using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuSC : MonoBehaviour
{
    public CanvasGroup tutorialMenu;
    public CanvasGroup pauseMenu;
    public CanvasGroup endGameMenu;

    // Start is called before the first frame update
    void Start()
    {
        if(tutorialMenu != null)
            closeTutorialMenu();
        if (pauseMenu != null)
            closePauseMenu();

    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            openPauseMenu();
        }

        
    }

    public void startGame()
    {
        SceneManager.LoadScene("House Level");
    }

    public void openTutorialMenu()
    {
        tutorialMenu.alpha = 1.0f;
        tutorialMenu.blocksRaycasts = true;
    }

    public void closeTutorialMenu()
    {
        tutorialMenu.alpha = 0.0f;
        tutorialMenu.blocksRaycasts = false;
    }

    public void openPauseMenu()
    {
        pauseMenu.alpha = 1.0f;
        pauseMenu.blocksRaycasts = true;
        pauseGame();
    }

    public void closePauseMenu()
    {
        pauseMenu.alpha = 0.0f;
        pauseMenu.blocksRaycasts = false;
        resumeGame();
    }

    public void endGame()
    {
        Application.Quit();
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
    }
}
