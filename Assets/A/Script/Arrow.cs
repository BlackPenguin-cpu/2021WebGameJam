using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Interaction
{
    public Node arrow;
    protected override void Action()
    {
        Debug.Log(arrow.name);
    }
    void Update()
    {
        
    }
}
