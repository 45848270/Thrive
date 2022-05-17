using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKitTimer : Item 
{
     public GameObject psRed;
    public GameObject psBlue;

    void OnTriggerEnter2D(Collider2D health)
    {
         if (health.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(health.gameObject);
            Instantiate(psRed,transform.position,Quaternion.identity);
            Destroy(gameObject); 
            Health.instance.Increase_P1_Health(); 
                                                                 
                                                                               
        }
        if (health.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(health.gameObject); 
            Instantiate(psBlue,transform.position,Quaternion.identity); 
            Destroy(gameObject); 
            Health.instance.Increase_P2_Health();  
                                                              
                                                                               
        }
    }
}
