using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        fadeIn.SetActive(true);
        RedirectToLevel.redirectToLevel = 3;
        RedirectToLevel.nextLevel = 5;
        StartCoroutine(FadeOff());
    }

    IEnumerator FadeOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
