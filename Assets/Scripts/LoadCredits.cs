using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCredits : MonoBehaviour
{
    public GameObject creditsRun;

    void Start()
    {
        StartCoroutine(RollCreds());
    }

    IEnumerator RollCreds()
    {
        yield return new WaitForSeconds(1.0f);

        creditsRun.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(1);
    }
}
