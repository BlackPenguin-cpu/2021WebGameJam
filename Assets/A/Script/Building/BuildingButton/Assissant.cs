using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assissant : Interaction
{
    protected override void Action()
    {
        if (RoadManager.Instance.selectnode.create >= 25)
        {
            SoundManager.Instance.PlaySound("건축");
            RoadManager.Instance.selectnode.create -= 25;
            RoadManager.Instance.selectnode.nachim = Node.NachimType.Assisant;
            RoadManager.Instance.obj.SetActive(false);
        }
        else SoundManager.Instance.PlaySound("에러"); ;
    }
}
