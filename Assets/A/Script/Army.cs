using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour
{
    public Node owner;
    public int create;
    public Node attack;
    public RectTransform rect
    {
        get
        {
            return this.GetComponent<RectTransform>();
        }
    }
    void Start()
    {
        rect.localPosition = owner.GetComponent<RectTransform>().localPosition;
    }

    void Update()
    {
        Vector2 me = gameObject.GetComponent<RectTransform>().localPosition;
        Vector2 target = attack.GetComponent<RectTransform>().localPosition;
        float angle = Mathf.Atan2(me.y - target.y, me.x - target.x) * Mathf.Rad2Deg;
        rect.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        rect.Translate(Vector3.down * 1);
        if(rect.localPosition.x - attack.GetComponent<RectTransform>().localPosition.x < 1 && rect.localPosition.y - attack.GetComponent<RectTransform>().localPosition.y < 1)
    }
}
