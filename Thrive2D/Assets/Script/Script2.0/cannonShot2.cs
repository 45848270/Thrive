using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonShot2 : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
    
    void OnTriggerEnter2D(Collider2D damageGivenToP1)
    {
        if (damageGivenToP1.gameObject.tag.Equals("Player2"))
            return;
        Destroy(gameObject);
        if (damageGivenToP1.gameObject.tag.Equals("Player1"))                                            //condition if it comes in contact with enemy
        {
            Health.instance.Decrease_P1_Health_Cannon();                                                                    
        }
        if (damageGivenToP1.gameObject.tag.Equals("player1Cannon"))                                            //condition if it comes in contact with enemy
        {
            Destroy(damageGivenToP1.gameObject);                                                      
                                                                              
        }
    }
}
