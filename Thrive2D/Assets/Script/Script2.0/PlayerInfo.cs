using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    public GameObject Panel1;
    public GameObject Panel2;



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Show Panel");
            bool isActive = Panel1.activeSelf;
            Panel1.SetActive(!isActive);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            bool isActive = Panel2.activeSelf;
            Panel2.SetActive(!isActive);
        }

    }


}