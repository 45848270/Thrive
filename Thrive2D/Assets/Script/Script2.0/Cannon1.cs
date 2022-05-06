using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    private AudioSource audioSource;


    void Awake()
    {
        instance = this;
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
            if (Input.GetKeyDown(KeyCode.LeftShift) && CannonShootOnce == true)
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
        GameObject cannon = Instantiate(cannonShotPrefab1, initialPos.position, initialPos.rotation);
        audioSource.PlayOneShot(cannonSound);
        cannonEffect.Play();
    }
    


}
