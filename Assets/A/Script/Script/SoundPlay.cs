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
            SoundManager.Instance.PlaySound("�й�");
        }
        else
        {
            SoundManager.Instance.PlaySound("��");
        }
        SoundManager.Instance.Playbgm("Ÿ��Ʋ");
        PhotonNetwork.Disconnect();
    }
}
