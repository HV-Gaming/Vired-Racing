using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClearText : MonoBehaviour
{

    public TMP_Text textMeshPro;
    public float clearTime = 5f;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("ClearTextMeshPro", clearTime);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ClearTextMeshPro()
    {
        textMeshPro.text = "";
    }
}
