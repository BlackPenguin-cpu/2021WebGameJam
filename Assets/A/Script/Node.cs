using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Node : Interaction
{
    public List<Node> linkednodes;
    public int create;
    public bool mine;
    private float duration;
    [SerializeField]
    private Image image;

    void Awake()
    {
        RoadManager.Instance.nodes.Add(gameObject.GetComponent<Node>());
    }

    protected override void Action()
    {
        if(RoadManager.Instance.nachim.Count > 0)
        {
            foreach (Image img in RoadManager.Instance.nachim)
            {
                GameObject.Destroy(img.gameObject);
            }
            RoadManager.Instance.nachim = new List<Image>();
        }
        foreach(Node node in linkednodes)
        {
            Vector2 me = gameObject.GetComponent<RectTransform>().localPosition;
            Vector2 target = node.gameObject.GetComponent<RectTransform>().localPosition;
            float angle = Mathf.Atan2(me.y - target.y, me.x - target.x) * Mathf.Rad2Deg;
            Image img = GameObject.Instantiate<Image>(image);
            img.GetComponent<RectTransform>().SetParent(gameObject.GetComponent<RectTransform>());
            img.GetComponent<RectTransform>().localPosition = Vector3.zero;
            img.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            img.GetComponent<RectTransform>().sizeDelta = new Vector2(1, 1);
            img.GetComponent<RectTransform>().rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            img.GetComponent<RectTransform>().Translate(Vector3.down * 1);
            img.GetComponent<Arrow>().arrow = node;
            RoadManager.Instance.nachim.Add(img);
        }
    }

    void Update()
    {
        if (mine)
        {
            duration += Time.deltaTime;
            if (duration >= 1)
            {
                create++;
                duration = 0;
            }
        }
    }
}
