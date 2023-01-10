using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CréerJoindre : MonoBehaviourPunCallbacks
{
    public InputField In;

    public void CreateRoom ()
    {
      PhotonNetwork.CreateRoom(In.text);
    }
    public void JoinRoom()
    {
      PhotonNetwork.JoinRoom(In.text);
    }

    public override void OnJoinedRoom()
    {
      PhotonNetwork.LoadLevel("Game");
    }
}
