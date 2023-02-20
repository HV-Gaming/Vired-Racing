using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }


    public void level1()
    {

        PlayerPrefs.SetInt("levelspawncount", 50);
        SceneManager.LoadScene("roadsample");
    }

    public void level2()
    {

        PlayerPrefs.SetInt("levelspawncount", 50);
        SceneManager.LoadScene("Level2");
    }

    public void level3()
    {

        PlayerPrefs.SetInt("levelspawncount", 50);
        SceneManager.LoadScene("Level3");
    }

    public void LevelSelect()
    {

        PlayerPrefs.SetInt("levelspawncount", 50);
        SceneManager.LoadScene("LevelSelect2");
    }

    public void PlaySelectedLevel()
    {

        if (PlayerPrefs.GetInt("SelectedLevel") == 0)
        {
            level1();

        }

        if (PlayerPrefs.GetInt("SelectedLevel") == 1)
        {
            level2();

        }

        if (PlayerPrefs.GetInt("SelectedLevel") == 2)
        {
            level3();

        }

    }

    public void SelectedLevel1()
    {
        PlayerPrefs.SetInt("SelectedLevel", 0);
    }

    public void SelectedLevel2()
    {
        PlayerPrefs.SetInt("SelectedLevel", 1);
    }

    public void SelectedLevel3()
    {
        PlayerPrefs.SetInt("SelectedLevel", 2);
    }

    public void MainMenu()
    {

        PlayerPrefs.SetInt("levelspawncount", 50);
        SceneManager.LoadScene("main_menu");
    }

    public void quit()
    {
        Application.Quit();
        //PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins")) + 200);
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }






}
