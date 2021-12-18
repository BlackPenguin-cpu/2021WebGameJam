using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Node : Interaction
{
    public List<Node> linkednodes;
    public int create;
    public bool mine;
    public bool your;
    public NachimType nachim = NachimType.None; 
    private float duration;
    [SerializeField]
    private Image image;
    [SerializeField]
    private TextMeshProUGUI text;

	void Awake()
	{
		RoadManager.Instance.nodes.Add(gameObject.GetComponent<Node>());
		if (!mine && !your)
		{
			text = GameObject.Instantiate<TextMeshProUGUI>(text);
			text.GetComponent<RectTransform>().SetParent(this.GetComponent<RectTransform>());
			text.GetComponent<RectTransform>().localPosition = Vector3.zero;
		}
	}

    protected override void Action()
    {
        if(RoadManager.Instance.selectnode == this)
        {
            if (RoadManager.Instance.nachim.Count > 0)
            {
                foreach (Image img in RoadManager.Instance.nachim)
                {
                    GameObject.Destroy(img.gameObject);
                }
                RoadManager.Instance.nachim = new List<Image>();
            }
            RoadManager.Instance.obj.SetActive(false);
            RoadManager.Instance.selectnode = new Node();
        }
        else if (mine)
        {
            if (RoadManager.Instance.nachim.Count > 0)
            {
                foreach (Image img in RoadManager.Instance.nachim)
                {
                    GameObject.Destroy(img.gameObject);
                }
                RoadManager.Instance.nachim = new List<Image>();
            }
            if(nachim == NachimType.None)
            {
                RoadManager.Instance.obj.SetActive(true);
            }
            else
            {
                RoadManager.Instance.obj.SetActive(false);
            }
            foreach (Node node in linkednodes)
            {
                Vector2 me = gameObject.GetComponent<RectTransform>().localPosition;
                Vector2 target = node.gameObject.GetComponent<RectTransform>().localPosition;
                float angle = Mathf.Atan2(me.y - target.y, me.x - target.x) * Mathf.Rad2Deg;
                Image img = GameObject.Instantiate<Image>(image);
                img.GetComponent<RectTransform>().SetParent(gameObject.GetComponent<RectTransform>());
                img.GetComponent<RectTransform>().localPosition = Vector3.zero;
                img.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                img.GetComponent<RectTransform>().sizeDelta = new Vector2(0.5f, 0.5f);
                img.GetComponent<RectTransform>().rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
                img.GetComponent<RectTransform>().Translate(Vector3.down * 1);
                img.GetComponent<Arrow>().arrow = node;
                RoadManager.Instance.nachim.Add(img);
            }
            RoadManager.Instance.selectnode = this;
        }
    }

    void Update()
    {
        if (mine || your)
        {
            duration += Time.deltaTime;
            if (duration >= 1)
            {
                int count = 1;
                if(nachim == NachimType.Farm)
                {
                    count++;
                }
                if (linkednodes.Find((Node x) => x.nachim == NachimType.Windvolume && x.mine) != null)
                {
                    count += linkednodes.FindAll((Node x) => x.nachim == NachimType.Windvolume && x.mine).Count;
                }
                create += count;
                duration = 0;
            }
        }
        if (mine)
        {
            text.color = new Color(0, 0, 1);
        }
        else if (your)
        {
            text.color = new Color(1, 0, 0);
        }
        else
        {
            text.color = new Color(0, 0, 0);
        }
        text.text = create.ToString();
        Image img = gameObject.GetComponent<Image>();
        if(nachim == NachimType.Assisant)
        {
            if (mine)
            {
                img.sprite = RoadManager.Instance.sprites[0];
            }
            else
            {
                img.sprite = RoadManager.Instance.sprites[1];
            }
        }
        else if(nachim == NachimType.Farm)
        {
            if (mine)
            {
                img.sprite = RoadManager.Instance.sprites[2];
            }
            else
            {
                img.sprite = RoadManager.Instance.sprites[3];
            }
        }
        else if (nachim == NachimType.HorseCreater)
        {
            if (mine)
            {
                img.sprite = RoadManager.Instance.sprites[4];
            }
            else
            {
                img.sprite = RoadManager.Instance.sprites[5];
            }
        }
        else if (nachim == NachimType.Windvolume)
        {
            if (mine)
            {
                img.sprite = RoadManager.Instance.sprites[6];
            }
            else
            {
                img.sprite = RoadManager.Instance.sprites[7];
            }
        }
    }

    public enum NachimType
    {
        None,
        Castle,
        Assisant,
        Windvolume,
        Farm,
        HorseCreater
    }
}
