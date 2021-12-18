using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : Interaction
{
    protected override void Action()
    {
        if (RoadManager.Instance.selectnode.create >= 10)
        {
            RoadManager.Instance.selectnode.create -= 10;
            RoadManager.Instance.selectnode.nachim = Node.NachimType.Farm;
            RoadManager.Instance.obj.SetActive(false);
        }
    }
}
