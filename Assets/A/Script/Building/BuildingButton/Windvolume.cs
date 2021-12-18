using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windvolume : Interaction
{
    protected override void Action()
    {
        if (RoadManager.Instance.selectnode.create >= 20)
        {
            SoundManager.Instance.PlaySound("건축");

            RoadManager.Instance.selectnode.create -= 20;
            RoadManager.Instance.selectnode.nachim = Node.NachimType.Windvolume;
            RoadManager.Instance.obj.SetActive(false);
        }
        else SoundManager.Instance.PlaySound("에러"); ;

    }
}
