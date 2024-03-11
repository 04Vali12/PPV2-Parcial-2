using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LevelManager : MonoBehaviour

{
    public static LevelManager Instance;
    [Header("LevelData")]
    public Subject Lesson;

    [Header("user interface")]
    public TMP_Text textQuestion;
    public List<Option> Options;
    public GameObject CheckButton;


    [Header("Game Configuration")]
    public int questionAmount = 0;
    public int currentQuestion = 0;
    public string question;
    public string CorrectAnswer;
    public int answerfromPlayer = 9;
    public GameObject AnswerContainer;
    public int currentAnswer;

    [Header("Current Lesson")]
    public Leccion currentLesson;

   

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }

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
            textQuestion.text = question;
            for (int i = 0; i < currentLesson.options.Count; i++)
            {
                Options[i].GetComponent<Option>().OptionName = currentLesson.options[i];
                Options[i].GetComponent<Option>().OptionID = i;
                Options[i].GetComponent<Option>().UpdateText();
            }
        }
        else
        {
            Debug.Log("Fin de las preguntas");
        }
    }
    public void NextQuestion()
    {
        if (currentQuestion < questionAmount)
        {
            bool isCorrect = currentLesson.options[answerfromPlayer] == CorrectAnswer;
            AnswerContainer.SetActive(true);
            if (isCorrect)
            {
                AnswerContainer.GetComponent<Image>().color = Color.green;
                Debug.Log("Respuesta Correcta" + question + ": " + currentAnswer);
            }
        }
    }
    public void SetPlayerAnswer(int _answer)
    {
        answerfromPlayer = _answer;
    }
    public bool CheckPlayerState()
    {
        if (answerfromPlayer != 9)
        {
            CheckButton.GetComponent<Button>().interactable = false;
            CheckButton.GetComponent<Image>().color = Color.white;
            return true;
        }
        else
        {
            CheckButton.GetComponent<Button>().interactable = false;
            CheckButton.GetComponent<Image>().color = Color.white;
            return false;
        }
    }

}
