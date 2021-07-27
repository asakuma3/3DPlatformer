using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;

    private void OnTriggerEnter()
    {
        GlobalScore.currentScore += 250;
        collectSound.Play();
        Destroy(gameObject);
    }
}
