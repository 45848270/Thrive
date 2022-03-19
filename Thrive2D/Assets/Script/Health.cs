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
        if(player1_health<=0)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player1"));
        }
        if(player2_health<=0)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player2"));
        }
    }

    public int Decrease_P1_Health()
    {
        player1_health-=damagePerContact;
        p1HealthText.text="Player1: "+ player1_health.ToString();
        return player1_health;
    }
    public int Decrease_P2_Health()
    {
        player2_health-=damagePerContact;
        p2HealthText.text="Player2: "+ player2_health.ToString();
        return player2_health;
    }

    public int Increase_P1_Health()
    {
        if(player1_health >= 100)
        {
            player1_health = 100;
        }
        else
        {
            player1_health+=regainHealth;   
        }
       p1HealthText.text="Player1: "+ player1_health.ToString();
        return player1_health;
    }

    public int Increase_P2_Health()
        {
            if(player2_health >= 100)
            {
                player2_health = 100;
            }
            else
            {
                player2_health+=regainHealth;   
            }
            p2HealthText.text="Player2: "+ player2_health.ToString();
            return player2_health;
        }
}
