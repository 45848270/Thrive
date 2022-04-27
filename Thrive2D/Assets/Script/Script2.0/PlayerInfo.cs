// using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{

    public GameObject Panel1;
    public GameObject Panel2;

    public GameObject Text1;
    public GameObject Text2;


    bool runOnce1;
    bool runOnce2;




    void Start()
    {
        runOnce1 = false;
        runOnce2 = false;

        Panel1.SetActive(false);
        Panel2.SetActive(false);

        Text1.SetActive(false);
        Text2.SetActive(false);


    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab)) // Show Player 1 information when Tab key pressed
        {
            bool isActive = Panel1.activeSelf;
            Panel1.SetActive(!isActive);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter)) // Show Player 2 information when KeypadEnter key pressed
        {
            bool isActive = Panel2.activeSelf;
            Panel2.SetActive(!isActive);
        }

        Player1Info();
        Player2Info();

    }

    // public void Player1Info()
    // {
    //     if ((runOnce1 == false) && (Activate_and_Deactivate.instance.script1.enabled))
    //     {
    //         Text1.SetActive(true);
    //         Debug.Log("got gun");
    //        // runOnce1 = true;


    //     }
    // }

     public void Player1Info()
    {
        if (Activate_and_Deactivate.instance.script1.enabled)
        {
            Text1.SetActive(true);
           // runOnce1 = true;


        }
    }

      public void Player2Info()
    {
        if ((Activate_and_Deactivate.instance.script2.enabled)        {
            Text2.SetActive(true);

            runOnce2 = true;


        }
    }

    // public void Player2Info()
    // {
    //     if ((runOnce2 == false) && (Activate_and_Deactivate.instance.script2.enabled))
    //     {
    //         Text2.SetActive(true);

    //         runOnce2 = true;


    //     }
    // }





}