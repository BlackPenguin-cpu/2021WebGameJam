using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Interaction
{
    public Node arrow;
    [SerializeField]
    private Army army;
    protected override void Action()
    {
        int a = Mathf.RoundToInt(((float)gameObject.GetComponent<RectTransform>().parent.GetComponent<Node>().create) / 10);
        if(a != 0)
        {
            gameObject.GetComponent<RectTransform>().parent.GetComponent<Node>().create -= a;
            Army asdf = GameObject.Instantiate<Army>(army);
            asdf.GetComponent<RectTransform>().SetParent(GameObject.Find("ArmyTeam").GetComponent<RectTransform>());
            asdf.attack = arrow;
            asdf.owner = gameObject.GetComponent<RectTransform>().parent.GetComponent<Node>();
            asdf.create = a;
            asdf.Hajimari();
        }
    }
    void Update()
    {
        
    }
}
