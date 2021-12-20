using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Chat;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.LocalPlayer.NickName = "�ձ���";
        PhotonNetwork.JoinOrCreateRoom("Room", new Photon.Realtime.RoomOptions { MaxPlayers = 2 }, null);
    }
    
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        photonView.RPC("GameStart", RpcTarget.All);
    }

    [PunRPC]
    void GameStart()
    {
        SceneManager.LoadScene("Stage1");
        SoundManager.Instance.PlaySound("���ӽ���");
        SoundManager.Instance.Playbgm("�ΰ���");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
