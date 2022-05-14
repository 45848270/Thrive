using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class P1Bullet : MonoBehaviourPunCallbacks
{

    public float speed=10f;
    public float destroyTime=2f;
    public bool duelGun = false;

     PhotonView view;

   // IEnumerator destroyBullet()
    //{
   //     yield return new WaitForSeconds(destroyTime);
  //      this.GetComponent<PhotonView>().RPC("destroy", RpcTarget.All);
  //  }
    // Start is called before the first frame update
   private void Start() 
   {
       this.GetComponent<PhotonView>().RPC("destroy", RpcTarget.All);
   }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    [PunRPC]
    public void destroy()
    {
        Destroy(gameObject,3f);
    }

    
   void OnTriggerEnter2D(Collider2D damageGiven)
    {
        if (damageGiven.gameObject.tag.Equals("Player")){
            P1FirstGunMP.instance.DamageGiven(20);
            this.GetComponent<PhotonView>().RPC("destroy", RpcTarget.All);
        }
        
    }
    
}
