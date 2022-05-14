using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2FirstGun : MonoBehaviour
{
    public static Player2FirstGun instance;
    public Transform initialPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float reloadTime = 2f;
    public float timeKeeper;
    public PlayerBaction controls;

    void Awake()
    {
        instance = this;
        controls = new PlayerBaction();
    }

    void Start()
    {
        timeKeeper = reloadTime;
    }

    // Update is called once per frame
    void Update()
    {
    //     if (timeKeeper <= 0)
    //     {
    //         if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5) )
    //         {
    //             shoot();
    //             timeKeeper = reloadTime;
    //         }
    //     }else
    //     {
             timeKeeper -= Time.deltaTime; 

    //     }
     }

    void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
       
    }
     public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed && (timeKeeper<=0))
        {

           
            shoot();
            timeKeeper=reloadTime;


        }
    }

    public void Decrease_P2_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
