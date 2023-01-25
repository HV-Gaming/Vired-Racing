using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finishline : MonoBehaviour
{
    public List<GameObject> finishers;

    public GameObject FinishPanel;
    public TMPro.TextMeshProUGUI FinishPosition;

    public TMPro.TextMeshProUGUI Coins;


    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> finishers = new List<GameObject>();
        FinishPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnCollisionExit(Collision other)
    {


        finishers.Add(other.gameObject);



        if (finishers[0].tag == "Player")
        {
            FinishPanel.SetActive(true);
            print("You Finished first");
            PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") + 100));
            print("100 coins added");
            FinishPosition.text = "You finished 1st";
            Coins.text = "+100 coins added";
        }

        if (finishers.Count > 1)
        {
            if (finishers[1].tag == "Player")
            {
                FinishPanel.SetActive(true);
                print("You Finished second");
                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") + 50));
                print("50 coins added");
                FinishPosition.text = "You finished 2nd";
                Coins.text = "+50 coins added";
            }
        }
        if (finishers[2].tag == "Player")
        {
            FinishPanel.SetActive(true);
            print("You Finished third");
            PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") + 20));
            print("20 coins added");
            FinishPosition.text = "You finished 3rd";
            Coins.text = "+20 coins added";
        }

        if (finishers[3].tag == "Player")
        {
            FinishPanel.SetActive(true);
            print("You Lost");
            FinishPosition.text = "You Lost";
            Coins.text = "+5 coins added";

        }
        if (finishers[4].tag == "Player")
        {
            FinishPanel.SetActive(true);
            print("You Lost");
            FinishPosition.text = "You Lost";

        }
        if (finishers[5].tag == "Player")
        {
            FinishPanel.SetActive(true);
            print("You Lost");
            FinishPosition.text = "You Lost";

        }


    }




    //Destroy(this.gameObject);




}





