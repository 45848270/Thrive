using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Cannon1 : MonoBehaviour
{
    public static Cannon1 instance;
    public Transform initialPos;
    public GameObject cannonShotPrefab1;
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

    }

    void shoot()
    {
        // shooting method
        GameObject cannon = Instantiate(cannonShotPrefab1, initialPos.position, initialPos.rotation);
        audioSource.PlayOneShot(cannonSound);
        cannonEffect.Play();
        
    }

    public void Fire2(InputAction.CallbackContext context)
    {
        
        {
            if (context.performed && (CannonShootOnce == true))
            {
                
                shoot();
                CannonShootOnce = false;
                // Update();


            }
        }
    }



}
