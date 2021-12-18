using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : Interaction
{
	protected override void Action()
	{
		SceneManager.LoadScene("Title");
	}
}
