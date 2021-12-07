using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField]
    float playTime = 300.0F;
    [SerializeField]
    Text timer;
    float startedTime;
    float elapsedTime;
    float timeLeft;

    void Start()
    {
        startedTime = Time.time;
    }

    void Update()
    {
        elapsedTime = Time.time - startedTime;
        timeLeft = playTime - elapsedTime;
        if (timeLeft <= 0.0F)
        {
            PlayerController player = FindObjectOfType<PlayerController>();
            player.Lose();
            enabled = false;
            return;
        }
        float minutes = (int)(timeLeft / 60.0F);
        float seconds = (int)(timeLeft % 60.0F);
        timer.text =
        string.Concat
        (
        string.Concat(minutes < 10 ? "0" : string.Empty, minutes.ToString()),
        ":",
        string.Concat(seconds < 10 ? "0" : string.Empty, seconds.ToString())
        );
    }
}