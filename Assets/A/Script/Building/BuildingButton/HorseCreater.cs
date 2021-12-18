using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseCreater : Interaction
{
    protected override void Action()
    {
        if (RoadManager.Instance.selectnode.create >= 15)
        {
            SoundManager.Instance.PlaySound("건축");

            RoadManager.Instance.selectnode.create -= 15;
            RoadManager.Instance.selectnode.nachim = Node.NachimType.HorseCreater;
            RoadManager.Instance.obj.SetActive(false);
        }
        else SoundManager.Instance.PlaySound("에러"); ;

    }
}
