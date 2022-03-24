using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1FirstGun : MonoBehaviour
{
    public Transform initialPos;
    public GameObject bulletPrefab;
    public float bulletForce=20f;


    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space)) 
        {
            shoot();
        }
    }

    void shoot()
    {
        //shooting method
       GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
       Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
       rb.AddForce(initialPos.up*bulletForce, ForceMode2D.Impulse);
    }
}
