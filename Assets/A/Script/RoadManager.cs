using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : Singleton<RoadManager>
{
    public List<Node> nodes = new List<Node>();
    [SerializeField]
    private SpriteRenderer sprite;
    void Start()
    {
        List<Node> connectnodes = new List<Node>();
        foreach(Node node in nodes)
        {
            foreach(Node node2 in node.linkednodes)
            {
                if (!connectnodes.Contains(node2))
                {
                    SpriteRenderer gameObject = GameObject.Instantiate<SpriteRenderer>(sprite);
                    gameObject.transform.SetParent(this.gameObject.transform);
                    gameObject.transform.localScale = new Vector3(1, 1, 1f);
                    gameObject.transform.position = (node.transform.localPosition + node2.transform.localPosition) / 2f;
                    Vector2 size = gameObject.size;
                    Vector3 line = node.transform.localPosition;
                    Vector3 toDirection2 = node2.transform.localPosition - line;
                    float x2 = toDirection2.magnitude;
                    size.x = x2;
                    gameObject.size = size;
                    gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.right, toDirection2) * Quaternion.FromToRotation(Vector3.forward, new Vector3(0f, 1f, 0f));
                }
            }
            connectnodes.Add(node);
        }
    }

    void Update()
    {
        
    }
}
