using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public quizManagerScript quizManager;

    public void answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
