using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public GameObject lobbyPannel;
    public GameObject roomPannel;
    public GameObject playerPrefab;
    public TMP_Text roomName;
    public TMP_InputField roomInput;

    public RoomItem roomItemPrefab;
    List<RoomItem> roomItemList= new List<RoomItem>();
    public Transform contentObject;

    public float timeBetweenUpdates =1.5f;
    float nextUpdateTime;

    public List<PlayerItem> playerItemsList = new List<PlayerItem>();
    public PlayerItem playerItemPrefab;
    public Transform playerItemParent;

    public GameObject playButton;

    private void Start()
    {
        PhotonNetwork.JoinLobby();
    }
    public void OnClickCreateRoom()
    {
        if (roomInput.text.Length>=1)
        {
         PhotonNetwork.CreateRoom(roomInput.text, new RoomOptions(){ MaxPlayers = 2, BroadcastPropsChangeToAll=true });
        }
        
    }

    public override void OnJoinedRoom()
    {
        lobbyPannel.SetActive(false);
        roomPannel.SetActive(true);
        roomName.text="Room Name: "+ PhotonNetwork.CurrentRoom.Name;
        UpdatePlayerList();

    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        if(Time.time >= nextUpdateTime)
        {
            UpdateRoomList(roomList);
            nextUpdateTime=Time.time + timeBetweenUpdates;
        }
        
    }

    void UpdateRoomList(List<RoomInfo> list)
    {
        foreach (RoomItem item in roomItemList)
        {
            Destroy(item.gameObject);
        }
        roomItemList.Clear();

        foreach(RoomInfo room in list)
        {
            RoomItem newRoom =Instantiate(roomItemPrefab, contentObject);
            newRoom.SetRoomName(room.Name);
            roomItemList.Add(newRoom);
        }


    }

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    public void OnClickleaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        roomPannel.SetActive(false);
        lobbyPannel.SetActive(true);
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    void UpdatePlayerList()
    {
            foreach (PlayerItem item in playerItemsList)
            {
                Destroy(item.gameObject);
            }
            playerItemsList.Clear();

            if(PhotonNetwork.CurrentRoom ==null)
            {
                return;
            }

            foreach(KeyValuePair<int, Player> player in PhotonNetwork.CurrentRoom.Players)
            {
                PlayerItem newPlayerItem = Instantiate(playerItemPrefab, playerItemParent);
                newPlayerItem.SetPlayerInfo(player.Value);

                if(player.Value == PhotonNetwork.LocalPlayer)
                {
                    newPlayerItem.ApplyLocalChanges();
                }

                playerItemsList.Add(newPlayerItem);
            }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        UpdatePlayerList();
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        UpdatePlayerList();
    }

    private void Update()
    {
        if (PhotonNetwork.IsMasterClient && PhotonNetwork.CurrentRoom.PlayerCount==2)
        {
            playButton.SetActive(true);
        }
        else
        {
            playButton.SetActive(false);
        }
    }

    public void OnClickPlayButton()
    {
        PhotonNetwork.LoadLevel("Game");
    }

}
