using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZone : MonoBehaviour
{
    public float zoneActivation_Time=1f;
    public bool player1ZoneTime=false;
    public bool player2ZoneTime=false;
    public float player1Time=2.0f;
    public float player2Time=2.0f;
    

    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player1ZoneTime)
        {
            player1Time-=Time.deltaTime;
            if(player1Time<=0)
            {
                Health.instance.Player1MaxHealth(1);
                player1Time=zoneActivation_Time;
            }
        }
        if(player2ZoneTime)
        {
            player2Time-=Time.deltaTime;
            if(player2Time<=0)
            {
                Health.instance.Player2MaxHealth(1);
                player2Time=zoneActivation_Time;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D healthzone)
    {
         if (healthzone.gameObject.tag.Equals("Player1"))                                            //condition if it comes in contact with enemy
        {
                player1ZoneTime=true;  
            


        }
        if (healthzone.gameObject.tag.Equals("Player2"))                                            //condition if it comes in contact with enemy
        { 
                player2ZoneTime=true;   
               
                                                                   
        }
    }
}
