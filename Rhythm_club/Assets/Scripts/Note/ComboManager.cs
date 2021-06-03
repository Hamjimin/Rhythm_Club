using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    [SerializeField] GameObject goComboImage = null;
    [SerializeField] GameObject goComboImage2 = null;
    [SerializeField] UnityEngine.UI.Text txtCombo = null;

    int currentCombo = 0;

    Animator myAnim;
    string animComboUp = "ComboUp";

    private void Start()
    {
        myAnim = GetComponent<Animator>();
        txtCombo.gameObject.SetActive(false);
        goComboImage.SetActive(false);
        goComboImage2.SetActive(false);
    }
    public void IncreaseCombo(int p_num = 1)
    {
        currentCombo += p_num;
        txtCombo.text = string.Format("{0:#,##0}", currentCombo);

        if(currentCombo > 2)
        {
            txtCombo.gameObject.SetActive(true);
            goComboImage.SetActive(true);
            goComboImage2.SetActive(true);

            myAnim.SetTrigger(animComboUp);
        }
    }
    public void ResetCombo()
    {
        currentCombo = 0;
        txtCombo.text = "0";
        txtCombo.gameObject.SetActive(false);
        goComboImage.SetActive(false);
        goComboImage2.SetActive(false);
    }
    public int GetCurrentCombo()
    {
        return currentCombo;
    }
}
