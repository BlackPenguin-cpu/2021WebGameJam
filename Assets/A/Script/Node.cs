using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public List<Node> linkednodes;
    public int create;
    public bool mine;
    private float duration;

    void Start()
    {
        RoadManager.instance.nodes.Add(this);
    }

    void Update()
    {
        if (mine)
        {
            duration += Time.deltaTime;
            if (duration >= 1)
            {
                create++;
            }
        }
    }
}
