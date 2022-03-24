using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider P1slider;
    public Slider P2slider;
    public static Health instance;
    public float player1DamagePerContact=30f;
    public float player2DamagePerContact=30f;
    public float regainHealth=50f;
    public float player1_health;
    public float player2_health;
    public GameObject p1;
    public GameObject p2;
    
    public void Awake()
    {
        instance = this;
          player1_health = 100f;
            player2_health = 100f;
    }
    

    void Start()
    {
        P1slider.value=player1_health;
        P2slider.value=player2_health;
    }

    public float IncreasePlayer1DamagePerCOntact()
    {
        player1DamagePerContact=player1DamagePerContact+(0.5f * player1DamagePerContact);
        return player1DamagePerContact;
    } 

    public float IncreasePlayer2DamagePerCOntact()
    {
        player2DamagePerContact=player2DamagePerContact+(0.5f * player2DamagePerContact);
        return player1DamagePerContact;
    }

    public float Decrease_P1_Health()
    {
        player1_health-=player1DamagePerContact;
        P1slider.value=player1_health;
        if(player1_health<=0)
        {
            Destroy(p1);
        }
        return player1_health;
    }
    public float Decrease_P2_Health()
    {
        player2_health-=player2DamagePerContact;
        P2slider.value=player2_health;
        if(player2_health<=0)
        {
            Destroy(p2);
        }
        return player2_health;
    }

    public float Increase_P1_Health()
    {
        player1_health+=regainHealth; 
        
        Debug.Log("Health Added");
        if(player1_health >= 100f)
        {
            player1_health = 100f;
        }
         P1slider.value=player1_health; 
        return player1_health;
    }

    public float Increase_P2_Health()
        {
            player2_health+=regainHealth;
            if(player2_health >= 100f)
            {
                player2_health = 100f;
            }
            P2slider.value=player2_health;
            return player2_health;
        }

    public void Player1MaxHealth()
    {
        player1_health=100f;
        P1slider.value=player1_health;
    }

    public void Player2MaxHealth()
    {
        player2_health=100f;
        P1slider.value=player2_health;
    }
}
