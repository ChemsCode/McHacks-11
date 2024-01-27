using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownText;
    float elapsedTime;


    int minutes;
    int seconds;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer() {
        elapsedTime += Time.deltaTime;
        minutes = Mathf.FloorToInt(elapsedTime / 60);
        seconds = Mathf.FloorToInt(elapsedTime % 60);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
