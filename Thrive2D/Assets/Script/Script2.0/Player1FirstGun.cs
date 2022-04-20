using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1FirstGun : MonoBehaviour
{
    public static Player1FirstGun instance;
    public Transform initialPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float reloadTime = 2f;

    public float timeKeeper;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        timeKeeper = reloadTime;
    }
    // Update is called once per frame
    void Update()
    {
        timeKeeper -= Time.deltaTime;
        if (timeKeeper <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shoot();
                timeKeeper = reloadTime;
            }
        }

    }

    void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(initialPos.up * bulletForce, ForceMode2D.Impulse);
    }

    public void Decrease_P1_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
