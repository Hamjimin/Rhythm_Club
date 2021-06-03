using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    FadeOut fadeOut;
    public GameObject CutScene1;
    public GameObject ClearUI;
    Player player;
    bool isClear = false;
    float PlayTime = 0;
    public int AudioLenght = 0;
    public void Start()
    {
        Time.timeScale = 0;
        fadeOut = FindObjectOfType<FadeOut>();
        player = FindObjectOfType<Player>();
    }

    public void Update()
    {
        PlayTime += Time.deltaTime;
        Debug.Log(PlayTime);

        if ((int)PlayTime == AudioLenght && player.hp > 0)
        {
            isClear = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CutScene1.SetActive(false);
            Time.timeScale = 1;
        }

        if(isClear == true)
        {
            ClearUI.SetActive(true);
            fadeOut.GoFade();
            Invoke("TurnScene", 2.5f);
        }
    }
    public void TurnScene()
    {
        SceneManager.LoadScene(0);
    }
}