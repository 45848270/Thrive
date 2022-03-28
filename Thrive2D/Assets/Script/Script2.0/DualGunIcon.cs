using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualGunIcon : MonoBehaviour
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
    void OnTriggerEnter2D(Collider2D DualGun)
    {
        
         if (DualGun.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Activate_and_Deactivate.instance.Activate_Player1_Second_Gun();                                                                   
        }
        if (DualGun.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Activate_and_Deactivate.instance.Activate_Player2_Second_Gun();                                                                     
        }
    }
}
