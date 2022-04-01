using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBase : MonoBehaviour
{
    public Slider hpSlider;
    public float moveSpeed = 1;
    public int MaxHp = 100;
    public int currentHp = 100;
    public KeyCode upKey,downKey, leftKey,rightKey;
    public KeyCode fireKey;
    private Vector3 moveDir;
    public float fireDis;
    public Transform gunTr;
    public Transform firePos;
    public Bullet bulletPre;
    public bool fireEnable = true;
    public float fireTimeSpace;
    private float timer;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        InitSelf();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = Vector3.zero;
        if(Input.GetKey(upKey))
        {
            moveDir.y = 1;
        }
        else if (Input.GetKey(downKey))
        {
            moveDir.y = -1;
        }
        if(Input.GetKey(leftKey))
        {
            moveDir.x = -1;
        }else if(Input.GetKey(rightKey))
        {
            moveDir.x = 1;
        }
        Move(moveDir);
        if (moveDir != Vector3.zero)
            gunTr.right = moveDir;
        if (!fireEnable)
        {
            if (timer <= 0)
            {
                timer = fireTimeSpace;
                fireEnable = true;
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
        if (Input .GetKey(fireKey))
        {
           if(fireEnable)
            {
                Fire();
                fireEnable = false;
                timer = fireTimeSpace;
            }
        }
    }
    public virtual void Fire()
    {
        Instantiate(bulletPre, firePos.position, firePos.rotation).damage = damage; 
    }

    public void Move(Vector3 dir)
    {
        transform .Translate (dir*Time .deltaTime *moveSpeed );
    }
    /// <summary>
    /// Initialization
    /// </summary>
    public virtual void InitSelf()
    {
        currentHp = MaxHp;
        hpSlider.maxValue = MaxHp;
        hpSlider.value = MaxHp;
    }
    /// <summary>
    /// Hurt
    /// </summary>
    /// <param name="damage"></param>
    public virtual void OnHurt(int damage)
    {
        currentHp -= damage;
        hpSlider.value = currentHp;
        if (currentHp <= 0) 
        {
            OnDie();
        }
    }
    public virtual void OnDie()
    {
        Destroy(gameObject);
    }

    public void AddHp(int add)
    {
        currentHp += add;
        currentHp = Mathf .Clamp (currentHp ,0,MaxHp );
        hpSlider.value = currentHp;
    }
    public void AddDamage(int dam)
    {
        damage += dam;
    }
}
