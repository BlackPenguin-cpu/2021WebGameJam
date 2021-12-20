using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SoundPlay : MonoBehaviour
{
    public bool fail;
    void Start()
    {
        if (fail)
        {
            SoundManager.Instance.PlaySound("패배");
        }
        else
        {
            SoundManager.Instance.PlaySound("승");
        }
        SoundManager.Instance.Playbgm("타이틀");
        PhotonNetwork.Disconnect();
    }
}
