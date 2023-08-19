using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] QuestionSO question;
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] GameObject[] answerButtons;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;
    int correctAnswerIndex;

    void Start()
    {
        DisplayQuestion();
    }

    public void OnAnswerSelected(int index)
    {
        Image buttonImage;
        Image falseImg;
        TextMeshProUGUI falseText;

        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Doğru!!";
            buttonImage = answerButtons[index].GetComponent<Image>();
            // buttonImage.color = new Color(0, 1, 0, (float)0.2);
            TextMeshProUGUI btnText = answerButtons[index].GetComponentInChildren<TextMeshProUGUI>();
            btnText.color = Color.white;
            btnText.fontWeight = FontWeight.Bold;
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            correctAnswerIndex = question.GetCorrectAnswerIndex();
            string correctAnswer = question.GetAnswer(correctAnswerIndex);
            questionText.text = "Aklın nerde bro doğru cevap:\n" + correctAnswer;
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
            falseImg = answerButtons[index].GetComponent<Image>();
            falseImg.color = new Color(1, 0, 0, (float)0.5);
            falseText = answerButtons[index].GetComponentInChildren<TextMeshProUGUI>();
            falseText.color = Color.white;
            falseText.fontWeight = FontWeight.Bold;
        }
    }

    void DisplayQuestion()
    {
        questionText.text = question.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    void SetButtonState(bool state)
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
        }
    }
}
