using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Cannon2 : MonoBehaviour
{
    public static Cannon2 instance;
    public Transform initialPos;
    public GameObject cannonShotPrefab2;
    ParticleSystem cannonEffect;
 
    public float bulletForce = 20f;
    public float reloadTime = 2f;
    public float timeKeeper;
    public static AudioClip cannonSound;
    public bool CannonShootOnce = false;
    public PlayerAction controls;



    private AudioSource audioSource;



    void Awake()
    {
        instance = this;
         controls = new PlayerAction();

    }

    void Start()
    {
        timeKeeper = reloadTime;

        audioSource = GetComponent<AudioSource>();
        cannonSound = Resources.Load<AudioClip>("Cannon");

        cannonEffect = GetComponent<ParticleSystem>();


    }
    // Update is called once per frame 
    void Update()
    {
        if (timeKeeper <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Keypad2) && CannonShootOnce == true)
            {
                shoot();
                CannonShootOnce = false;
                timeKeeper = reloadTime;
            }
        }
        else
        {
            timeKeeper -= Time.deltaTime;

        }

    }

    void shoot()
    {
        //shooting method
        GameObject cannon = Instantiate(cannonShotPrefab2, initialPos.position, initialPos.rotation);
        audioSource.PlayOneShot(cannonSound);
        cannonEffect.Play();


        // bullet.GetComponent <Player1bullet >().
    }

 public void Fire2(InputAction.CallbackContext context)
    {
        if (CannonShootOnce == true)
        {
            if (context.performed)
            {
                shoot();
                CannonShootOnce = false;
                // Update();
            }
        }
    }



    // public void Decrease_P1_ReloadTime()
    // {
    //     reloadTime -= (0.15f * reloadTime);
    // }
}
