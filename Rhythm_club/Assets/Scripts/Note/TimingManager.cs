using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    Vector2[] timingBoxs = null;

    EffectManager theEffectManager;
    ScoreManager theScoreManager;
    ComboManager theComboManager;

    void Start()
    {
        theEffectManager = FindObjectOfType<EffectManager>();
        theScoreManager = FindObjectOfType<ScoreManager>();
        theComboManager = FindObjectOfType<ComboManager>();

        timingBoxs = new Vector2[timingRect.Length];

        for(int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.localPosition.x - timingRect[i].rect.width / 2, Center.localPosition.x + timingRect[i].rect.width / 2);
        }
    }

    public void CheckTiming()
    {
        for(int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = boxNoteList[i].transform.localPosition.x;

            for(int j = 0; j < timingBoxs.Length; j++)
            {
                if (timingBoxs[j].x <= t_notePosX && t_notePosX <= timingBoxs[j].y)
                {
                    //노트제거
                    boxNoteList[i].GetComponent<Note>().HideNote();
                    boxNoteList.RemoveAt(i);

                    //이펙트연출
                    if (j < timingBoxs.Length - 1)
                        theEffectManager.NoteHitEffect(); //perfect, cool, good 판정때만 이펙트, bad일땐 x
                    theEffectManager.JudgementEffect(j);
                    theScoreManager.IncreaseScore(j);

                    return;
                }
            }
            
        }
        theEffectManager.JudgementEffect(timingBoxs.Length);
        theComboManager.ResetCombo();
    }

    public void CheckTiming2()
    {
        for (int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = boxNoteList[i].transform.localPosition.x;

            for (int j = 0; j < timingBoxs.Length; j++)
            {
                if (timingBoxs[j].x <= t_notePosX && t_notePosX <= timingBoxs[j].y)
                {
                    //노트제거
                    boxNoteList[i].GetComponent<Note2>().HideNote();
                    boxNoteList.RemoveAt(i);

                    //이펙트연출
                    if (j < timingBoxs.Length - 1)
                        theEffectManager.NoteHitEffect(); //perfect, cool, good 판정때만 이펙트, bad일땐 x
                    theEffectManager.JudgementEffect(j);
                    theScoreManager.IncreaseScore(j);

                    return;
                }
            }

        }
        theEffectManager.JudgementEffect(timingBoxs.Length);
        theComboManager.ResetCombo();
    }
}
