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
    public float timeKeeper;
    public PlayerAction controls;




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

        timeKeeper -= Time.deltaTime;
    }

    void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
        // bullet.GetComponent <Player1bullet >().
    }


    public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed && (timeKeeper <= 0))
        {

            shoot();
            timeKeeper = reloadTime;


        }
    }



    public void Decrease_P1_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
