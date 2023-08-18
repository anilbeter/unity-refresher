using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] QuestionSO question;
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] GameObject[] answerButtons;

    void Start()
    {
        questionText.text = question.GetQuestion();

        TextMeshProUGUI buttonText = answerButtons[0].GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = question.GetAnswer(0);
    }
}
