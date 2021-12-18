using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : Interaction
{
	public GameObject Title, DeveloperPannel;
	public int TitleNum;
	protected override void Action()
	{
		if (TitleNum == 0)
		{
			SceneManager.LoadScene("Main");
		}
		if (TitleNum == 1)
		{
			Debug.Log("���� ����");
		}
		if (TitleNum == 2)
		{
			Title.SetActive(false);
			DeveloperPannel.SetActive(true);
		}
		if (TitleNum == 3)
		{
			DeveloperPannel.SetActive(false);
			Title.SetActive(true);
		}
		if (TitleNum == 4)
		{
			Debug.Log("����");
		}
	}

	protected override void Start()
	{
		base.Start();
	}
}
