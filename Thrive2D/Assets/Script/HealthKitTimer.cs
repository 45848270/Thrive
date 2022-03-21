using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKitTimer : MonoBehaviour
{
    public float healthkitLastFor=4f;
    private float time1;
    // Start is called before the first frame update
    void Start()
    {
      time1=healthkitLastFor;  
    }

    // Update is called once per frame
    void Update()
    {
        time1-=Time.deltaTime;
            if(time1<=0)
            {
                Destroy(gameObject);
            }
        
    }
    void OnTriggerEnter2D(Collider2D health)
    {
         if (health.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(health.gameObject);
            Destroy(gameObject); 
            Health.instance.Increase_P1_Health(); 
                                                                 
                                                                               
        }
        if (health.gameObject.tag.Equals("Player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(health.gameObject);  
            Destroy(gameObject); 
            Health.instance.Increase_P2_Health();  
                                                              
                                                                               
        }
    }
}
