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
            SoundManager.Instance.PlaySound("게임시작");
            SoundManager.Instance.Playbgm("인게임");
            SceneManager.LoadScene("Stage1");
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
            Application.Quit();
        }
    }

}
