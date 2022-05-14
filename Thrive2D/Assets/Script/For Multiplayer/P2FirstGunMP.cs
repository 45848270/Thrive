using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class P2FirstGunMP : MonoBehaviour
{
    public static P2FirstGunMP instance;
    public Transform initialPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float reloadTime = 2f;
    public float timeKeeper;
    public PlayerAction controls;

    PhotonView view;



    void Awake()
    {
        instance = this;
        controls = new PlayerAction();
    }

    void Start()
    {
        view=GetComponent<PhotonView>();
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
        if(view.IsMine)
        {
        if (context.performed && (timeKeeper<=0))
        {

            Debug.Log("Fire!");
            shoot();
            timeKeeper=reloadTime;


        }
        }
    }



    public void Decrease_P2_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
