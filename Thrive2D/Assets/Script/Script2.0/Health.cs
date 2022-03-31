using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider P1slider;
    public Slider P2slider;
    public static Health instance;
    public float player1DamagePerContact=10f;
    public float player2DamagePerContact=10f;
    public float player1_regainHealth=20f;
    public float player2_regainHealth=20f;
    public float player1_health;
    public float player2_health;
    public GameObject p1;
    public GameObject p2;
    public float p1_Slidder_HealthValue;
    public float p2_Slidder_HealthValue;
    public float player1_CurrentHealth;
    public float player2_CurrentHealth;

    public float time1;
    public float time2;

    public float x;
    public float y;



    
    public void Awake()
    {
        instance = this;
          player1_health = 100f;
          player2_health = 100f;

          player1_CurrentHealth=player1_health;
          player2_CurrentHealth=player2_health;

            p1_Slidder_HealthValue=player1_CurrentHealth;
            p2_Slidder_HealthValue=player2_CurrentHealth;

         
    }
    

    void Start()
    {
        P1slider.value=p1_Slidder_HealthValue;
        P2slider.value=p1_Slidder_HealthValue;
    }
    void Update()
    {
        P1slider.maxValue=player1_health;
        P1slider.value=player1_CurrentHealth;

        P2slider.maxValue=player2_health;
        P2slider.value=player2_CurrentHealth;
    
    }

    /*public void SetPlayer1Health()
    {
        Debug.Log("Function called");
        p1_Slidder_HealthValue=(player1_CurrentHealth/player1_health)*100;
        P1slider.value=p1_Slidder_HealthValue;
    }

    public void SetPlayer2Health()
    {
        Debug.Log("Function called");
          p2_Slidder_HealthValue=(player2_CurrentHealth/player2_health)*100;
        P2slider.value=p2_Slidder_HealthValue;
    }*/

    public float IncreasePlayer1DamagePerCOntact()
    {
        player1DamagePerContact=player1DamagePerContact+(0.9f * player1DamagePerContact);
        return player1DamagePerContact;
    } 

    public float IncreasePlayer2DamagePerCOntact()
    {
        player2DamagePerContact=player2DamagePerContact+(0.9f * player2DamagePerContact);
        return player1DamagePerContact;
    }

    public float Decrease_P1_Health()
    {
        player1_CurrentHealth-=player1DamagePerContact;
        //SetPlayer1Health();
        if(player1_CurrentHealth<=0)
        {
            Destroy(p1);
        }
        return player1_CurrentHealth;
    }
    public float Decrease_P2_Health()
    {
        player2_CurrentHealth-=player2DamagePerContact;
        //SetPlayer2Health();
        if(player2_CurrentHealth<=0)
        {
            Destroy(p2);
        }
        return player2_CurrentHealth;
    }

    public float Increase_P1_Health()
    {
        player1_health+=player1_regainHealth;
        player1_CurrentHealth+=player1_regainHealth; 
        player1_regainHealth=player1_regainHealth+player1_regainHealth*(0.5f);
        
        Debug.Log("Health Added");
         //SetPlayer1Health();
        return player1_health;
    }

    public float Increase_P2_Health()
    {
            player2_health+=player2_regainHealth;
            player2_CurrentHealth+=player2_regainHealth;
            player2_regainHealth=player2_regainHealth+player2_regainHealth*(0.5f);
           //SetPlayer2Health();
            return player2_health;
    }

    public void Player1MaxHealth(int value)
    { 
        player1_CurrentHealth+=value;

        if (player1_CurrentHealth>=player1_health)
        {
            player1_CurrentHealth=player1_health;
        }
        
    }

    public void Player2MaxHealth(int value)
    {
        player2_CurrentHealth+=value;
        
        if (player2_CurrentHealth>=player2_health)
        {
            player2_CurrentHealth=player2_health;
        }

        
    }
}
