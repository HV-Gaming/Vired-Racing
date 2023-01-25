using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Awake()
    {
        {

            Time.timeScale = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);
    }
}
