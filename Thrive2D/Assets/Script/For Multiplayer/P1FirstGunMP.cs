using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class P1FirstGunMP : MonoBehaviourPunCallbacks
{
   public static P1FirstGunMP instance;
    public Transform initialPos;
     public Transform secondPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float reloadTime = 2f;
    public float timeKeeper;
    public PlayerAction controls;
    public bool dualGunOn = false;

    PhotonView view;

    public float health=100;
    public float currentHealth;

    //public ParticleSystem ps;




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

          if(view.IsMine)
            {
                 if (Input.GetKeyDown(KeyCode.Space))
                 {
                  //Shoot();
                  Debug.Log("Fire!");
                    view.RPC("Shoot",RpcTarget.All);
                    timeKeeper=reloadTime;
                 }    
        }

    }

    [PunRPC]
    void Shoot()
    {
       // ps.Play();

        //Ray ray=new Ray(initialPos.position, initialPos.up);
        //if (Physics.Raycast(ray, out RaycastHit hit, 100f))
       // {
        //    var enemyHealth =hit.collider.GetComponent<HealthMP>();
        //    if (enemyHealth)
        //    {
        //        enemyHealth.TakeDamage(20);
        //    }
       // }
        //shooting method
        GameObject bullet = PhotonNetwork.Instantiate(bulletPrefab.name, initialPos.position, initialPos.rotation);


       if (dualGunOn == true) 
        {
           GameObject bullet1 = PhotonNetwork.Instantiate(bulletPrefab.name, secondPos.position, secondPos.rotation); 
        }
    }

    [PunRPC]
    public void ActivateDualGun()
    {
        dualGunOn=true;
    }

    [PunRPC]
    public void DamageGiven(int damage){
        TakeDamage(damage);
    }
     [PunRPC]
    public void TakeDamage(int damage)
    {
        health-=damage;
    }
    public void Decrease_P1_ReloadTime()
    {
        reloadTime -= (0.15f * reloadTime);
    }
}
