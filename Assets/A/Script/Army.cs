using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Army : MonoBehaviour
{
	public Node owner;
	public int create;
	public Node attack;
	[SerializeField]
	private Sprite sprite;
	[SerializeField]
	private Sprite sprite2;
	public RectTransform rect
	{
		get
		{
			return this.GetComponent<RectTransform>();
		}
	}
	public void Hajimari()
	{
		rect.localPosition = owner.GetComponent<RectTransform>().localPosition;
		rect.localScale = new Vector3(1, 1, 1);
		rect.sizeDelta = new Vector2(30, 60);
		if (owner.mine)
		{
			gameObject.GetComponent<Image>().sprite = sprite;
		}
		else
		{
			gameObject.GetComponent<Image>().sprite = sprite2;
		}
	}

	void Update()
	{
		Vector2 me = gameObject.GetComponent<RectTransform>().localPosition;
		Vector2 target = attack.GetComponent<RectTransform>().localPosition;
		float angle = Mathf.Atan2(me.y - target.y, me.x - target.x) * Mathf.Rad2Deg;
		rect.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
		rect.Translate(Vector3.down * Time.deltaTime);
		if (Mathf.Abs(rect.localPosition.x - attack.GetComponent<RectTransform>().localPosition.x) < 6 && Mathf.Abs(rect.localPosition.y - attack.GetComponent<RectTransform>().localPosition.y) < 6)
		{
			if (attack.mine)
			{
				attack.create += create;
			}
			else
			{
				attack.create -= create * 100;
				if (attack.create <= 0)
				{
					attack.create = 0;
					attack.your = false;
					attack.mine = true;
				}
			}
			GameObject.Destroy(this.gameObject);
		}
	}
}
