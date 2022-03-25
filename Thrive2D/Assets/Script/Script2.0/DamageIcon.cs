using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIcon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D DamageIncrease)
    {
        
         if (DamageIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Health.instance.IncreasePlayer2DamagePerCOntact();                                                                    
        }
        if (DamageIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Health.instance.IncreasePlayer1DamagePerCOntact();                                                                    
        }
    }
}
