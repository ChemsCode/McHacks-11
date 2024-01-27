using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void PlayGame() {
        Console.WriteLine("play button pressed");
        SceneManager.LoadSceneAsync(1);
    }  
}
