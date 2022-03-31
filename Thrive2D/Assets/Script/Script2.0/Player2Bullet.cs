using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,3f);
    }
    
    void OnTriggerEnter2D(Collider2D damageGivenToP1)
    {

         if (damageGivenToP1.gameObject.tag.Equals("Player1"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Health.instance.Decrease_P1_Health();                                                                    
        }
        if (damageGivenToP1.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(damageGivenToP1.gameObject);                                                      
            Destroy(gameObject);                                                                    
        }
    }
}
