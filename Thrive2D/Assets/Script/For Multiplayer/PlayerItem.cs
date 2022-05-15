using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PlayerItem : MonoBehaviourPunCallbacks
{
 public TMP_Text playerName;

 //Image backGroundImage;
 public Color highlightColor;
 public GameObject leftArrowKey;
 public GameObject rightArrowKey;

 ExitGames.Client.Photon.Hashtable playerProperties = new ExitGames.Client.Photon.Hashtable();

 public Image playerAvatar;
 public Sprite[] avatars;

 Player player;


 private void Start()
 {
    // backGroundImage=GetComponent<Image>();
 }

 public void SetPlayerInfo(Player _player)
 {
     playerName.text = _player.NickName;
     player = _player;
     UpdatePlayerItem(player);
 }

  public void ApplyLocalChanges()
  {
      //backGroundImage.color=highlightColor;
      leftArrowKey.SetActive(true);
      rightArrowKey.SetActive(true);

  }

  public void OnClickLeftArrow()
  {
      if((int)playerProperties["playerAvatar"] == 0)
      {
          playerProperties["playerAvatar"] = avatars.Length-1;
      }
      else{
          playerProperties["playerAvatar"] = (int)playerProperties["playerAvatar"] -1;
      }
      PhotonNetwork.SetPlayerCustomProperties(playerProperties);
  }

   public void OnClickRightArrow()
  {
      if((int)playerProperties["playerAvatar"] == avatars.Length-1)
      {
          playerProperties["playerAvatar"] = 0;
      }
      else{
          playerProperties["playerAvatar"] = (int)playerProperties["playerAvatar"] + 1;
      }

      PhotonNetwork.SetPlayerCustomProperties(playerProperties);
  }

  public override void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable playerProperties)
  {
      if(player ==targetPlayer)
      {
         UpdatePlayerItem(targetPlayer); 
      }
  }

  void UpdatePlayerItem(Player player)
  {
      if(player.CustomProperties.ContainsKey("playerAvatar"))
      {
          playerAvatar.sprite=avatars[(int) player.CustomProperties["playerAvatar"]];
          playerProperties["playerAvatar"]=(int)player.CustomProperties["playerAvatar"];
      }
      else
      {
             playerProperties["playerAvatar"]=0;
      }
  }


}
