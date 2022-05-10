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
        //     timeKeeper -= Time.deltaTime;

        // }



    }

    void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
        // bullet.GetComponent <Player1bullet >().
    }

    // void onEnable()
    // {
    //     move = controls.Player.Move;
    //     move.Enable();

    //     fire = controls.Player.Fire;
    //     fire.Enable();
    //     fire.performed += Fire;
    // }

    // void onDisable()
    // {
    //     move.Disable();
    //     fire.Disable();
    // }

    public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

            Debug.Log("Fire!");
            shoot();
            

        }
    }










    public void Decrease_P1_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
