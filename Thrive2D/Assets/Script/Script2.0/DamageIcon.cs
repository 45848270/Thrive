using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIcon : Item
{
    public GameObject psRed;
    public GameObject psBlue;
    // Update is called once per frame
    void Update() 
    {
    }

    void OnTriggerEnter2D(Collider2D DamageIncrease)
    {

        if (DamageIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            DamageA.incrementDamA += 1;
            Destroy(DamageIncrease.gameObject);
            Instantiate(psRed, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Health.instance.IncreasePlayer1DamagePerCOntact();
        }
        if (DamageIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            DamageB.incrementDamB += 1;
            Destroy(DamageIncrease.gameObject);
            Instantiate(psBlue, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Health.instance.IncreasePlayer2DamagePerCOntact();
        }
    }
}
