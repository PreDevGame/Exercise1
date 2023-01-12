using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool pausedGame;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseJingle;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        { 
            if(pausedGame == false)
            {
                pauseMenu.SetActive(true);
                pauseJingle.Play();
                Time.timeScale = 0;
                pausedGame = true;
                Cursor.visible = true;
                levelMusic.Pause();
            }
            else
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                pausedGame = false;
                Cursor.visible = false;
                levelMusic.UnPause();
            }
        }
    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pausedGame = false;
        Cursor.visible = false;
        levelMusic.UnPause(); 
    }
    public void restartLevel()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pausedGame = false;
        Cursor.visible = false;
        levelMusic.UnPause();
        SceneManager.LoadScene(2);
    }

    public void quitToMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pausedGame = false;
        Cursor.visible = false;
        levelMusic.UnPause();
        SceneManager.LoadScene(1);
    }
}
