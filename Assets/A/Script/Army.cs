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
        
    }
}
