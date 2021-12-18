using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RoadManager : Singleton<RoadManager>
{
    public List<Node> nodes = new List<Node>();
    public List<Image> nachim = new List<Image>();
    public Node selectnode = new Node();
    public GameObject obj;
    public List<Sprite> sprites = new List<Sprite>();

    protected override void Awake()
    {
        if (Instance != this)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    void Start()
    {
        SoundManager.Instance.PlaySound("게임시작");
        SoundManager.Instance.Playbgm("인게임");
    }
}
