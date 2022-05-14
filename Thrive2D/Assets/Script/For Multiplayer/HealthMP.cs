using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class HealthMP : MonoBehaviourPunCallbacks, IPunObservable
{

public static HealthMP instance;
    public float health=100;
    public float currentHealth;


    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
        {
            if(stream.IsWriting)
            {
                stream.SendNext(health);
            }
            else
           {
                {
                    health=(int)stream.ReceiveNext();
                }
            }
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    
    [PunRPC]
    void Start()
    {
        currentHealth=health;
    }

    public void TakeDamage(int damage)
    {
        health-=damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
