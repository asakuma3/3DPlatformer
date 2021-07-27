using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    public GameObject theRogo;

    void Start()
    {
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        theRogo.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(1);
    }


}
