using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text txtScore = null;

    [SerializeField] int increaseScore = 10;
    public int currentScore = 0;

    [SerializeField] float[] weight = null;
    [SerializeField] int comboWeight = 10;

    ComboManager theCombo;

    Animator myAnim;
    string animScoreUp = "ScoreUp";
    void Start()
    {
        myAnim = GetComponent<Animator>();
        theCombo = FindObjectOfType<ComboManager>();
        currentScore = 0;
        txtScore.text = "0";
    }

    // Update is called once per frame
    public void IncreaseScore(int p_JudgementState)
    {
        //�޺� ����
        theCombo.IncreaseCombo();

        //�޺� ���ʽ� ���� ���
        int t_currentCombo = theCombo.GetCurrentCombo();
        int t_bonusComboScore = (t_currentCombo / 10) * comboWeight;

        //����ġ���
        int t_increaseScore = increaseScore + t_bonusComboScore;
        t_increaseScore = (int)(t_increaseScore * weight[p_JudgementState]);

        //int t_increaseScore = increaseScore + t_bonusComboScore;
        //t_increaseScore = (int)(t_increaseScore * weight[p_JudgementState]); -> �̰Ÿ� ����� �޺�����ġ x

        //�����ݿ�
        currentScore += t_increaseScore;
        txtScore.text = string.Format("{0:#,##0}", currentScore);

        myAnim.SetTrigger(animScoreUp);
    }
}
