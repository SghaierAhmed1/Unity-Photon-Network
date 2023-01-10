using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;

public class PlayerListing : MonoBehaviour
{
  private Player _player;

  public void SetPlayerInfo(Player player)
  {
    _player = player;
  }
}
