using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIcon : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D DamageIncrease)
    {
        
         if (DamageIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(DamageIncrease.gameObject);
            Destroy(gameObject);
            Health.instance.IncreasePlayer2DamagePerCOntact();                                                                    
        }
        if (DamageIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(DamageIncrease.gameObject);
            Destroy(gameObject);
            Health.instance.IncreasePlayer1DamagePerCOntact();                                                                    
        }
    }
}
