using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZone : MonoBehaviour
{
    
    public float healthkitLastFor=4f;
    public bool player1ZoneTime=false;
    public bool player2ZoneTime=false;
    public float player1Time=0f;
    public float player2Time=0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(player1ZoneTime)
        {
            player1Time+=Time.deltaTime;
            if(player1Time>=15f)
            {
                Health.instance.Player1MaxHealth();
                player1Time=0f;
            }
        }
        if(player2ZoneTime)
        {
            player2Time+=Time.deltaTime;
            if(player2Time>=15f)
            {
                Health.instance.Player2MaxHealth();
                player2Time=0f;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D healthzone)
    {
         if (healthzone.gameObject.tag.Equals("Player1"))                                            //condition if it comes in contact with enemy
        {
                player1Time=0f;
                player1ZoneTime=true;  

        }
        if (healthzone.gameObject.tag.Equals("Player2"))                                            //condition if it comes in contact with enemy
        { 
                player2Time=0f;
                player2ZoneTime=true;                                                                      
        }
    }
}
