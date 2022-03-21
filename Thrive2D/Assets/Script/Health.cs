using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static Health instance;
    public int damagePerContact=30;
    public int regainHealth=50;
    public int player1_health;
    public int player2_health;
    public GameObject p1;
    public GameObject p2;
    public Text p1HealthText;
    public Text p2HealthText;
    
    public void Awake()
    {
        instance = this;
          player1_health = 100;
            player2_health = 100;
            p1HealthText.text="Player1: "+ player1_health.ToString();
            p2HealthText.text="Player2: "+ player2_health.ToString();
    }
    

    void Update()
    {
    
    }

    public int Decrease_P1_Health()
    {
        player1_health-=damagePerContact;
        if(player1_health<=0)
        {
            Destroy(p1);
        }
        p1HealthText.text="Player1: "+ player1_health.ToString();
        return player1_health;
    }
    public int Decrease_P2_Health()
    {
        player2_health-=damagePerContact;
        if(player2_health<=0)
        {
            Destroy(p2);
        }
        p2HealthText.text="Player2: "+ player2_health.ToString();
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
          
       p1HealthText.text="Player1: "+ player1_health.ToString();
        return player1_health;
    }

    public int Increase_P2_Health()
        {
            player2_health+=regainHealth;
            if(player2_health >= 100)
            {
                player2_health = 100;
            }
            p2HealthText.text="Player2: "+ player2_health.ToString();
            return player2_health;
        }
}
