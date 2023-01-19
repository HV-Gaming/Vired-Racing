using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public List<GameObject> finishers;


    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> finishers = new List<GameObject>();

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
            print("You Finished first");
        }

        if (finishers.Count > 1)
        {
            if (finishers[1].tag == "Player")
            {
                print("You Finished second");
            }
            if (finishers[2].tag == "Player")
            {
                print("You Finished third");
            }

            if (finishers[3].tag == "Player")
            {
                print("You Lost");

            }


        }




        //Destroy(this.gameObject);




    }

}



