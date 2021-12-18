using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windvolume : Interaction
{
    protected override void Action()
    {
        if (RoadManager.Instance.selectnode.create >= 20)
        {
            RoadManager.Instance.selectnode.create -= 20;
            RoadManager.Instance.selectnode.nachim = Node.NachimType.Windvolume;
            RoadManager.Instance.obj.SetActive(false);
        }
    }
}
