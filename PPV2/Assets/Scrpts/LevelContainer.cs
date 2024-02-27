using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelContainer : MonoBehaviour
{
    [Header("GameObject Configuration")]
    public int Lection = 0;
    public int CurrentLession = 0;
    public int TotalLessions = 0;
    public bool AreaAllLessonsComplete = false;

    [Header("UI Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonStage;

    [Header("External GameObject Configuration")]
    public GameObject lessonContainer;

    [Header("Lesson Data")]
    public ScriptableObject LessonData;

    void Start()
    {
        if (lessonContainer != null)
        {
            OnUpdateUI();
        }
        else
        {
            Debug.LogWarning("GameObject nulo, revisa las variables del tipo GameObject LessonContainer");
        }
    }
    public void OnUpdateUI()
    {
        if(StageTitle != null || LessonStage != null)
        {
            StageTitle.text = "leccion" + Lection;
            LessonStage.text = "Leccion " + CurrentLession + "de" + TotalLessions;

        }
        else
        {
            Debug.LogWarning("GameObject nulo, revisa las variables del tipo TMP_Text");
        }
    }
    public void EnableWindow()
    {
        OnUpdateUI();

        if (lessonContainer.activeSelf)
        {
            lessonContainer.SetActive(false);
        }
        else
        {
            lessonContainer.SetActive(true);
        }
    }
}
