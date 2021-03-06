using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseJungle;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                pauseJungle.Play();
                pauseMenu.SetActive(true);

                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
            }
            else
            {
                pauseJungle.Pause();
                pauseMenu.SetActive(false);

                levelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }


    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }


    public void RestartLevel()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(2);

        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }


    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);

        //levelMusic.UnPause();
        //Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

}
