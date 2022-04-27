// using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public float UpdatedSpeedA;
    public float CurrentSpeedA;
    public float UpdatedDamageA;
    public float CurrentDamageA;
    public float UpdatedHealthA;
    public float CurrentHealthA;




    public float UpdatedSpeedB;
    public float CurrentSpeedB;
    public float UpdatedDamageB;
    public float CurrentDamageB;
    public float UpdatedHealthB;
    public float CurrentHealthB;



    public GameObject PanelA;
    public GameObject PanelB;

    public GameObject PlayerAText1;
    public GameObject PlayerAText2;
    public GameObject PlayerAText3;
    public GameObject PlayerAText4;


    public GameObject PlayerBText1;
    public GameObject PlayerBText2;
    public GameObject PlayerBText3;
    public GameObject PlayerBText4;




    void Start()
    {

        CurrentSpeedA = Movement.instance.accelerationFactor;
        CurrentSpeedB = Movement2.instance.accelerationFactor;

        CurrentDamageA = Health.instance.player1DamagePerContact;
        CurrentDamageB = Health.instance.player2DamagePerContact;

        CurrentHealthA = Health.instance.player1_health;
        CurrentHealthB = Health.instance.player1_health;






        PanelA.SetActive(false);
        PanelB.SetActive(false);

        PlayerAText1.SetActive(false);
        PlayerAText2.SetActive(false);
        PlayerAText3.SetActive(false);
        PlayerAText4.SetActive(false);


        PlayerBText1.SetActive(false);
        PlayerBText2.SetActive(false);
        PlayerBText3.SetActive(false);
        PlayerBText4.SetActive(false);



    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab)) // Show Player 1 information when Tab key pressed
        {
            bool isActive = PanelA.activeSelf;
            PanelA.SetActive(!isActive);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter)) // Show Player 2 information when KeypadEnter key pressed
        {
            bool isActive = PanelB.activeSelf;
            PanelB.SetActive(!isActive);
        }

        UpdatedSpeedA = Movement.instance.accelerationFactor;
        UpdatedSpeedB = Movement2.instance.accelerationFactor;

        UpdatedDamageA = Health.instance.player1DamagePerContact;
        UpdatedDamageB = Health.instance.player2DamagePerContact;

        UpdatedHealthA = Health.instance.player1_health;
        UpdatedHealthB = Health.instance.player2_health;




        Player1Info();
        Player2Info();

        //  Debug.Log(Health.instance.player1_health);


    }


    public void Player1Info()
    {
        if (Activate_and_Deactivate.instance.script1.enabled)
        {
            PlayerAText1.SetActive(true);
        }
        if (UpdatedSpeedA > CurrentSpeedA)
        {
            PlayerAText2.SetActive(true);
        }
        if (UpdatedDamageA > CurrentDamageA)
        {
            PlayerAText3.SetActive(true);
        }
        if (UpdatedHealthA > CurrentHealthA)
        {
            PlayerAText4.SetActive(true);
        }



    }

    public void Player2Info()
    {
        if (Activate_and_Deactivate.instance.script2.enabled)
        {
            PlayerBText1.SetActive(true);
        }
        if (UpdatedSpeedB > CurrentSpeedB)
        {
            PlayerBText2.SetActive(true);
        }
        if (UpdatedDamageB > CurrentDamageB)
        {
            PlayerBText3.SetActive(true);
        }
         if (UpdatedHealthB > CurrentHealthB)
        {
            PlayerBText4.SetActive(true);
        }

    }







}