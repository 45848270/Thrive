using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystem : MonoBehaviour
{
    private PlayerControlls input;
    private InputAction movement;
   // private InputAction direction;
    public Movement mover;
    
    


    public Transform firstGunPos;
    public Transform secondGunPos;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float reloadTime = 2f;
    public float timeKeeper;

    private bool secondGunActive=false;

     private void Awake()
    {
       input= new PlayerControlls();
    }

    void Start()
    {
        timeKeeper = reloadTime;
        input.Player.Fire.performed += OnFire;
    }

    private void OnEnable()
    {
        movement=input.Player.Movement;
        //direction=input.Player.Direction;
        movement.Enable();
       // direction.Enable();

        
        input.Player.Fire.Enable();
    }

    private void OnFire(InputAction.CallbackContext obj)
    {
        if (timeKeeper <= 0)
        { 
                shoot();
                timeKeeper = reloadTime;
        }
    }

    private void OnDisable()
    {
        movement.Disable();
      //  direction.Disable();
        input.Player.Fire.Disable();
    }

    private void Update()
    {
            timeKeeper -= Time.deltaTime;
    }
   private void FixedUpdate()
    {
        mover.SetVerticalMovement(movement.ReadValue<Vector2>());
        //mover.SetHorizontalMovement(direction.ReadValue<float>());
    }
     public void shoot()
    {
        //shooting method
        GameObject bullet = Instantiate(bulletPrefab, firstGunPos.position, firstGunPos.rotation);
        if (secondGunActive)
        {
        GameObject bullet1 = Instantiate(bulletPrefab, secondGunPos.position, secondGunPos.rotation);  
        }
       // bullet.GetComponent <Player1bullet >().
    }

    public void setSecondGun()
    {
        secondGunActive=true; 
    }
}
