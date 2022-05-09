using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    public float MovSpeed=3f;
    private CharacterController controller;

    private Vector2 moveDirection=Vector2.zero;
    private float ver=0;
    
    private void Awake()
    {
        controller=GetComponent<CharacterController>();
    }
    
    public void SetInputVector(float f)
    {
        ver=f;
    }

    // Update is called once per frame
    void Update()
    {

       moveDirection=new Vector2(0,ver);
       moveDirection=transform.TransformDirection(moveDirection);
       moveDirection.Normalize();
       moveDirection*=MovSpeed;

       controller.Move(moveDirection*Time.deltaTime);
    }
}
