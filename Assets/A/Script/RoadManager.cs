using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public static RoadManager Instance { get; private set; }
    public List<Node> nodes = new List<Node>();
    public List<Image> nachim = new List<Image>();
    public Node selectnode = new Node();
    public GameObject obj;
    public List<Sprite> sprites = new List<Sprite>();


}
