using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkRoomManager : MonoBehaviourPunCallbacks
{

    public void CreateRoom() // коли створюэш кімнату, ти автоматом приєднуєшся до неї
    {
        PhotonNetwork.CreateRoom("roomname");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("roomname");
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Hub1");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
