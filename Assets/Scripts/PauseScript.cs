using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPaused = false;
    public GameObject PauseMenu;
    public GameObject TimerObject;


    void Start()
    {
        PauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        PauseMenu.SetActive(true);
        TimerObject.SetActive(false);
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        PauseMenu.SetActive(false);
        TimerObject.SetActive(true);
    }
}




