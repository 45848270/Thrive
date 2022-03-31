using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1bullet : MonoBehaviour
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
    
    void OnTriggerEnter2D(Collider2D damageGivenToP2)
    {

         if (damageGivenToP2.gameObject.tag.Equals("Player2"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Health.instance.Decrease_P2_Health();                                                                    
        }
        if (damageGivenToP2.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(damageGivenToP2.gameObject);                                                      
            Destroy(gameObject);                                                                    
        }
    }
}
