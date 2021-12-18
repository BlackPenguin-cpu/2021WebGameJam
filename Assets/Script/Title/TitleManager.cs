using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : Interaction
{
	public GameObject Title, DeveloperPannel, ClosePannel;
	public int TitleNum;
	protected override void Action()
	{
		if (TitleNum == 0)
		{
			SceneManager.LoadScene("Main");
		}
		if (TitleNum == 1)
		{
			Title.SetActive(false);
			ClosePannel.SetActive(true);
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
			Debug.Log("설정");
		}
		if (TitleNum == 5)
		{
			ClosePannel.SetActive(false);
			Title.SetActive(true);
		}
		if (TitleNum == 6)
		{
			Debug.Log("게임 종료");
		}
	}

	protected override void Start()
	{
		base.Start();
	}
}
