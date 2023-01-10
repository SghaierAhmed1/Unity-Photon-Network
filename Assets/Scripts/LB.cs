using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class LB : MonoBehaviour
{
    // Start is called before the first frame update
    public void leave()
    {
      PhotonNetwork.LeaveRoom();
      SceneManager.LoadScene("MainMenu");
    }
}
