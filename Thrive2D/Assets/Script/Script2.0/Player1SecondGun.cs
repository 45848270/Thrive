using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player1SecondGun : MonoBehaviour
{
    public static Player1SecondGun instance;
    public Transform initialPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float reloadTime = 2f;
    public bool dualGunOn = false;

    public PlayerAction controls;


    public float timeKeeper;

    void Awake()
    {
        instance = this;
        controls = new PlayerAction();

    }

    void Start()
    {
        timeKeeper = reloadTime;
    }

    // Update is called once per frame
    void Update()
    {
        // if (timeKeeper <= 0)
        // {
        //     if (Input.GetKeyDown(KeyCode.Space))
        //     {
        //         shoot();
        //         timeKeeper = reloadTime;
        //     }
        // }
        // else
        // {
             timeKeeper -= Time.deltaTime;
        // }
    }

    void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);

    }

    public void Fire(InputAction.CallbackContext context)
    {
        if (dualGunOn == true)
        {
            if (context.performed && (timeKeeper<=0))
            {

            shoot();
            timeKeeper=reloadTime;
            }
        }
    }

    public void Decrease_P1_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
