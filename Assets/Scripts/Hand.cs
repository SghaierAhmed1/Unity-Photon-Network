using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;
public class Hand : MonoBehaviour
{
    public GameObject sc;
    public GameObject ro;
    public GameObject pa;
    public GameObject test;
    private ExitGames.Client.Photon.Hashtable played = new ExitGames.Client.Photon.Hashtable();
    public string c;
    public Player pp;
    Player remote = PhotonNetwork.LocalPlayer.GetNext();
    Player local = PhotonNetwork.LocalPlayer;
    public Player Player {get; private set;}
    public GameObject fake;

 public PhotonView view;

  public void start ()
  {
    view = GetComponent<PhotonView>();
    pp = PhotonNetwork.LocalPlayer;
  }

  public void SetPlayed()
  {
    played["Choix"] = c;
    PhotonNetwork.LocalPlayer.CustomProperties = played;
  //  remote.SetCustomProperties(played);
  //  local.CustomProperties = played;
  }

  public void SetPlayerInfo(Player player)
  {
    Player = player;
    string result = (string)player.CustomProperties["Choix"];
  }

  public void scissors ()
  {

    ro.transform.position = new Vector3(2.11f,-10.55f,0);
    pa.transform.position = new Vector3(2.11f,-10.55f,0);
    sc.GetComponent<Animation>().Play("ScissorsAnim");
    c = "scissors";
    SetPlayed();
    Debug.Log(local.CustomProperties);
    if (PhotonNetwork.LocalPlayer.GetNext().CustomProperties["Choix"] == "paper")
    {
      Debug.Log("you win");
      Debug.Log(PhotonNetwork.LocalPlayer.GetNext().CustomProperties["Choix"]);
      fake.SetActive(true);
    }

  }
  public void rock ()
  {

    sc.transform.position = new Vector3(1.94f,-10.68f,0);
    pa.transform.position = new Vector3(2.11f,-10.55f,0);
    ro.GetComponent<Animation>().Play("RockAnim");
    c = "rock";
    SetPlayed();
    Debug.Log(local.CustomProperties);

  }
  public void paper ()
  {

    sc.transform.position = new Vector3(1.94f,-10.68f,0);
    ro.transform.position = new Vector3(2.11f,-10.55f,0);
    pa.GetComponent<Animation>().Play("PaperAnim");
    c = "paper";
    SetPlayed();
    Debug.Log(local.CustomProperties);

}

public void update()
{

}

}
