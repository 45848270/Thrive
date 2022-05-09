using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1FirstGun : MonoBehaviour
{
    public static Player1FirstGun instance;
    public Transform initialPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float reloadTime = 2f;

    public bool fire=false;

    public float timeKeeper;

    private PlayerControlls input;

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
        if (timeKeeper <= 0)
        {
            if (fire)
            {
                shoot();
                timeKeeper = reloadTime;
            }
        }else 
        {
            timeKeeper -= Time.deltaTime;

        }

    }

    public void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
       // bullet.GetComponent <Player1bullet >().
    }

    public void Decrease_P1_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
