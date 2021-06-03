using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public GameObject UIStartBtn;
    public GameObject UIOptionBtn;
    public GameObject UIQuitBtn;
    public GameObject PlayScene;
    public GameObject SoundScene;
    public AudioSource Button;
    public AudioSource Start;

    public void ClickStartBtn()
    {
        PlayScene.SetActive(true);
        Button.Play();
    }
    public void ClickOptionBtn()
    {
        SoundScene.SetActive(true);
        Button.Play();
    }
    public void ClickOffBtn_P()
    {
        PlayScene.SetActive(false);
        Button.Play();
    }
    public void ClickOffBtn_S()
    {
        SoundScene.SetActive(false);
        Button.Play();
    }
    public void ClickStg1Btn()
    {
        Start.Play();
        SceneManager.LoadScene(1);
    }
    public void ClickStg2Btn()
    {
        Start.Play();
        SceneManager.LoadScene(2);
    }
    public void ClickQuitBtn()
    {
        Button.Play();
        Application.Quit();
    }
}
