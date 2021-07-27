using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        fadeIn.SetActive(true);
        RedirectToLevel.redirectToLevel = 5;
        RedirectToLevel.nextLevel = 6;
        StartCoroutine(FadeOff());
    }

    IEnumerator FadeOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
