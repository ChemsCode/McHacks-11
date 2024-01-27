using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class wallTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI wallText;
    [SerializeField] float timeUntilNextWall = 8f;
    [SerializeField] float timeToHoldPosition = 3f;
    float walltime = 8f;
    bool holdingPosition = false;

    int wallSeconds;
    TextMeshProUGUI motivationText;
    String[] motivations = new string[] {"The wall is coming!", "Everybody get ready to pose!", "Big Wall time"};
    String[] motivationPose = new string[] {"What a pose!", "Strike that pose Cuzzo!", "Such flexibility X.X"};


    void Start () {
        motivationText = GameObject.FindWithTag("motivation").GetComponent<TextMeshProUGUI>();
        motivationText.text = "Game is starting \n Get in position!!!";
    }

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer() {
        walltime -= Time.deltaTime;

        wallSeconds = Mathf.FloorToInt(walltime % 60);
        wallText.text = string.Format("{0:00}", wallSeconds);


        if (walltime <= 0 && holdingPosition == false) {
            walltime = timeToHoldPosition; 
            ChangeWallStatus();
        }

        if (walltime <= 0 && holdingPosition == true) {
            walltime = timeUntilNextWall;
            ChangeWallStatus();
        }
    }

    void ChangeWallStatus() {
        if (holdingPosition == true) {
            holdingPosition = false;
            motivationText.text = motivations[UnityEngine.Random.Range(0, motivations.Length)];
        }
        else {
            holdingPosition = true;
            motivationText.text = motivationPose[UnityEngine.Random.Range(0, motivations.Length)];
        }
    } 
}
