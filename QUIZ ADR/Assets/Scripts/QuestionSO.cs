using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter a new question here";

    public string GetQuestion()
    {
        return question;
    }
}

public class Test
{
    readonly QuestionSO questionSO;

    void TestA()
    {
        string questionText = questionSO.GetQuestion();
        // Görüldüğü gibi başka bir class'dan public olan GetGuestion() methoduma erişim sağlayabiliyorum, çünkü public yaptım.
    }
}