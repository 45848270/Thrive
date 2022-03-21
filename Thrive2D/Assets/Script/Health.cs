using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider P1slider;
    public Slider P2slider;
    public static Health instance;
    public int damagePerContact=30;
    public int regainHealth=50;
    public int player1_health;
    public int player2_health;
    public GameObject p1;
    public GameObject p2;
    
    public void Awake()
    {
        instance = this;
          player1_health = 100;
            player2_health = 100;
    }
    

    void Start()
    {
        P1slider.value=player1_health;
        P2slider.value=player2_health;
    }

    public int Decrease_P1_Health()
    {
        player1_health-=damagePerContact;
        P1slider.value=player1_health;
        if(player1_health<=0)
        {
            Destroy(p1);
        }
        return player1_health;
    }
    public int Decrease_P2_Health()
    {
        player2_health-=damagePerContact;
        P2slider.value=player2_health;
        if(player2_health<=0)
        {
            Destroy(p2);
        }
        return player2_health;
    }

    public int Increase_P1_Health()
    {
        player1_health+=regainHealth; 
        
        Debug.Log("Health Added");
        if(player1_health >= 100)
        {
            player1_health = 100;
        }
         P1slider.value=player1_health; 
        return player1_health;
    }

    public int Increase_P2_Health()
        {
            player2_health+=regainHealth;
            if(player2_health >= 100)
            {
                player2_health = 100;
            }
            P2slider.value=player2_health;
            return player2_health;
        }
}
