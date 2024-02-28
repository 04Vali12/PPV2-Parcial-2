using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LevelManager : MonoBehaviour
{
    [Header("LevelData")]
    public Subject Lesson;

    [Header("user interface")]
    public TMP_Text textQuestion;

    [Header("Game Configuration")]
    public int questionAmount = 0;
    public int currentQuestion = 0;
    public string question;
    public string CorrectAnswer;

    [Header("Current Lesson")]
    public Leccion currentLesson;
    // Start is called before the first frame update
    void Start()
    {
        questionAmount = Lesson.leccionList.Count;
        LoadQuestion();
    }

    // Update is called once per frame
    public void LoadQuestion()
    {
        if (currentQuestion < questionAmount)
        {
            currentLesson = Lesson.leccionList[currentQuestion];
            question = currentLesson.options[currentLesson.CorrectAnswer];
            CorrectAnswer = currentLesson.options[currentLesson.CorrectAnswer];
        }
        else
        {
            Debug.Log("Fin de las preguntas");
        }
    }
    public void NextQuestion()
    {
        if(currentQuestion < questionAmount)
        {
            currentQuestion++;
            LoadQuestion();
        }
    }


}
