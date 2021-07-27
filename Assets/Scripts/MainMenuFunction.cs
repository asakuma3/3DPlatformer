using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public static int bestScore;
    public AudioSource buttonPress;
    public GameObject bestScoreDisplay;

    private void Start()
    {
        Cursor.visible = true;
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "BEST SCORE: " + bestScore;
    }


    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }


    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }


    public void ResetScore()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        PlayerPrefs.SetInt("LevelScore5", 0);
        bestScoreDisplay.GetComponent<Text>().text = "BEST SCORE: " + bestScore;

    }
}
