using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelcomplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject levelBlocker;
    public GameObject fadeOut;

    private void OnTriggerEnter()
    {

        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;   

        timeCalc = GlobalTimer.extendScore * 100;
        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " Å~ 100 ";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);

        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelcomplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1f);

        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1f);

        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
