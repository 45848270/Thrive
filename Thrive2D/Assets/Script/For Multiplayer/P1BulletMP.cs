using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class P1BulletMP : MonoBehaviourPunCallbacks
{

    public float speed=10f;
    public float destroyTime=2f;
    public bool duelGun = false;

     PhotonView view;

    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(destroyTime);
        this.GetComponent<PhotonView>().RPC("destroy", RpcTarget.All);
    }
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    [PunRPC]
    public void destroy()
    {
        Destroy(gameObject);
    }

    
   void OnTriggerEnter2D(Collider2D damageGiven)
    {
        if (damageGiven.gameObject.tag.Equals("Player")){
            P1FirstGunMP.instance.DamageGiven(20);
            this.GetComponent<PhotonView>().RPC("destroy", RpcTarget.All);
        }
        
    }
    
}
