using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon2 : MonoBehaviour
{
    public static Cannon2 instance;
    public Transform initialPos;
    public GameObject cannonShotPrefab2;
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

        // bullet.GetComponent <Player1bullet >().
    }

    // public void Decrease_P1_ReloadTime()
    // {
    //     reloadTime -= (0.15f * reloadTime);
    // }
}
