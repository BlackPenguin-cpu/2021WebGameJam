using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public abstract class Interaction : MonoBehaviour
{
    // 버튼에다 상속하는 상속 클래스 버튼에 상속시 Action 함수에 버튼 클릭시 발동할 코드 적어놓으면 클릭할때 발동함
    Button button;
    protected virtual void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => { Action(); });
        button.onClick.AddListener(() => { SoundManager.Instance.PlaySound("클릭_버튼"); });
    }

    protected abstract void Action();


}
