using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int hp = 15;
    public HpBar hpbar;
    Animator myAnim;
    FadeOut fadeOut;
    string isDead = "isDead";
    void Start()
    {
        myAnim = GetComponent<Animator>();
        fadeOut = FindObjectOfType<FadeOut>();
    }

    public void GetDamage()
    {
        hp -= 2;
        hpbar.SetHp(hp);
        if(hp <= 0)
        {
            Die();
        }
    }
    public void GetDamage2()
    {
        hp -= 8;
        hpbar.SetHp(hp);
        if (hp <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        myAnim.SetBool(isDead, true);
        fadeOut.GoFade();
        Invoke("TurnScene", 2f);
    }
    public void TurnScene()
    {
        SceneManager.LoadScene(0);
    }
}
