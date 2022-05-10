using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public static Player1FirstGun instance;
    public Transform initialPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    PlayerAction controls;


    void Awake()
    {

        controls = new PlayerAction();
        controls.Player.Fire.performed += ctx => Fire();
    }

    void Fire()
    {
        // shoot();
        Debug.Log("shooting");
    }

    void onEnable()
    {
        controls.Player.Enable();
    }

    void onDisable()
    {
        controls.Player.Disable();
    }

    // void Update()
    // {        
    //         if (Input.GetKeyDown(KeyCode.Space))
    //         {
    //             shoot();
    //         }       


    // }

    void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
    }


}
