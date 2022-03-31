using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKitTimer : MonoBehaviour
{
    public float destroyTime=5f;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
                Destroy(gameObject,destroyTime);
        
    }
    void OnTriggerEnter2D(Collider2D health)
    {
         if (health.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(health.gameObject);
            Destroy(gameObject); 
            Health.instance.Increase_P1_Health(); 
                                                                 
                                                                               
        }
        if (health.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(health.gameObject);  
            Destroy(gameObject); 
            Health.instance.Increase_P2_Health();  
                                                              
                                                                               
        }
    }
}
