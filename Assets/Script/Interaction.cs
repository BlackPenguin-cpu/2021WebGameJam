using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public abstract class Interaction : MonoBehaviour
{
    // ��ư���� ����ϴ� ��� Ŭ���� ��ư�� ��ӽ� Action �Լ��� ��ư Ŭ���� �ߵ��� �ڵ� ��������� Ŭ���Ҷ� �ߵ���
    Button button;
    private bool waha;
    protected virtual void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => { Action(); });
        button.onClick.AddListener(() => { SoundManager.Instance.PlaySound("Ŭ��_��ư"); });
    }
    void update()
    {
        if(waha == false)
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(() => { Action(); });
            button.onClick.AddListener(() => { SoundManager.Instance.PlaySound("Ŭ��_��ư"); });
            waha = true;
        }
    }

    protected abstract void Action();


}
