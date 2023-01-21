using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinchanger : MonoBehaviour
{

    public GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {


        // If it does, get the value and enable the gameobjects
        int value = PlayerPrefs.GetInt("PlayerSkin");

        gameObjects[value].SetActive(true);


    }



    // Update is called once per frame
    void Update()
    {

    }
}
