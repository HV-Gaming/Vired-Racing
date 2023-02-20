using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class skinmanager : MonoBehaviour
{

    public TMPro.TextMeshProUGUI Coincount;

    public TMPro.TextMeshProUGUI Message;
    public GameObject Lock2Overlay;
    public GameObject Lock3Overlay;

    public GameObject LevelLock2Overlay;

    public GameObject LevelLock3Overlay;

    private void Awake()
    {
        //PlayerPrefs.SetInt("Coins", 100);
        //PlayerPrefs.SetInt("skin1status", 0);
        //PlayerPrefs.SetInt("skin2status", 0);
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        Coincount.text = PlayerPrefs.GetInt("Coins").ToString();

        if (PlayerPrefs.GetInt("skin1status") == 1)
        {
            Lock2Overlay.SetActive(false);
        }
        else
        {
            Lock2Overlay.SetActive(true);

        }



        if (PlayerPrefs.GetInt("skin2status") == 0)
        {
            Lock3Overlay.SetActive(true);
        }
        else
        {
            Lock3Overlay.SetActive(false);

        }


        if (PlayerPrefs.GetInt("level2status") == 1)
        {
            LevelLock2Overlay.SetActive(false);
        }
        else
        {
            LevelLock2Overlay.SetActive(true);

        }


        if (PlayerPrefs.GetInt("level3status") == 1)
        {
            LevelLock3Overlay.SetActive(false);
        }
        else
        {
            LevelLock3Overlay.SetActive(true);

        }







    }

    public IEnumerator ClearTextMeshPro()
    {
        yield return new WaitForSeconds(5f);
        Message.text = "";

    }


    public void level2()
    {




        if (PlayerPrefs.GetInt("Coins") >= 50)
        {
            if (PlayerPrefs.GetInt("level2status") == 0)
            {

                //PlayerPrefs.SetInt("PlayerSkin", 1);
                PlayerPrefs.SetInt("level2status", 1);
                print("unlocked");
                Message.text = "Unlocked";
                StartCoroutine(ClearTextMeshPro());

                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") - 50));
                SceneManager.LoadScene("Level2");

            }
            else
            {
                //PlayerPrefs.SetInt("level2status", 1);
                print("Already unlocked");
                Message.text = "Already Unlocked";
                StartCoroutine(ClearTextMeshPro());
                SceneManager.LoadScene("Level2");


            }



            //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        }

        else
        {
            print("not enough coins");
            Message.text = "Not Enough Coins";
            StartCoroutine(ClearTextMeshPro());
        }
    }


    public void level3()
    {




        if (PlayerPrefs.GetInt("Coins") >= 100)
        {
            if (PlayerPrefs.GetInt("level2status") == 0)
            {

                //PlayerPrefs.SetInt("PlayerSkin", 1);
                PlayerPrefs.SetInt("level3status", 1);
                print("unlocked");
                Message.text = "Unlocked";
                StartCoroutine(ClearTextMeshPro());
                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") - 100));
                SceneManager.LoadScene("Level3");

            }
            else
            {
                //PlayerPrefs.SetInt("level2status", 1);
                print("Already unlocked");
                Message.text = "Already Unlocked";
                StartCoroutine(ClearTextMeshPro());
                SceneManager.LoadScene("Level3");


            }



            //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        }

        else
        {
            print("not enough coins");
            Message.text = "Not enough coins";
            StartCoroutine(ClearTextMeshPro());
        }
    }






















    public void skin1()
    {

        if (PlayerPrefs.GetInt("Coins") >= 10)
        {
            if (PlayerPrefs.GetInt("skin1status") == 0)
            {

                PlayerPrefs.SetInt("PlayerSkin", 1);
                PlayerPrefs.SetInt("skin1status", 1);
                print("unlocked");
                Message.text = "Unlocked";
                StartCoroutine(ClearTextMeshPro());
                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") - 10));

            }
            else
            {
                PlayerPrefs.SetInt("PlayerSkin", 1);
                print("Already unlocked");
                Message.text = "Already Unlocked";
                StartCoroutine(ClearTextMeshPro());
            }



            //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        }
        else
        {
            print("not enough coins");
            Message.text = "not enough coins";
            StartCoroutine(ClearTextMeshPro());
        }



    }

    public void skin2()
    {

        if (PlayerPrefs.GetInt("Coins") >= 40)
        {
            if (PlayerPrefs.GetInt("skin2status") == 0)
            {

                PlayerPrefs.SetInt("PlayerSkin", 2);
                PlayerPrefs.SetInt("skin2status", 1);
                print("unlocked");
                Message.text = "Unlocked";
                StartCoroutine(ClearTextMeshPro());
                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") - 40));

            }
            else
            {
                PlayerPrefs.SetInt("PlayerSkin", 2);
                print("Already unlocked");
                Message.text = "Already Unlocked";
                StartCoroutine(ClearTextMeshPro());
            }



            //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        }
        else
        {
            print("not enough coins");
            Message.text = "not enough coins";
            StartCoroutine(ClearTextMeshPro());
        }



    }

    public void skin3()
    {

        if (PlayerPrefs.GetInt("Coins") >= 80)
        {
            if (PlayerPrefs.GetInt("skin3status") == 0)
            {

                PlayerPrefs.SetInt("PlayerSkin", 3);
                PlayerPrefs.SetInt("skin3status", 1);
                print("unlocked");
                Message.text = "Unlocked";
                StartCoroutine(ClearTextMeshPro());
                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") - 40));

            }
            else
            {
                print("Already unlocked");
                Message.text = "Already Unlocked";
                StartCoroutine(ClearTextMeshPro());
                PlayerPrefs.SetInt("PlayerSkin", 3);
            }



            //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        }
        else
        {
            print("not enough coins");
            Message.text = "not enough coins";
            StartCoroutine(ClearTextMeshPro());
        }



    }

    public void defaultSkin()
    {


        PlayerPrefs.SetInt("PlayerSkin", 0);
        //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));





    }
}
