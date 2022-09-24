using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quizManagerScript : MonoBehaviour
{
    public List<questionanswerScript> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text questionText;
    public Text scoreText;
    int totalQuestions = 0;
    public int score;

    public GameObject quizPanel;
    public GameObject goPAnel;
    private void Start() 
    {
        totalQuestions = QnA.Count;
        goPAnel.SetActive(false);
        quizPanel.SetActive(true);
        generateQuestion();
    }

    public void gameOver()
    {
        quizPanel.SetActive(false);
        goPAnel.SetActive(true);
        scoreText.text = score + "/" + totalQuestions;
    }

    public void reTry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<answerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].answers[i];

            if(QnA[currentQuestion].correctAnswers == i+1)
            {
                options[i].GetComponent<answerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0 )
        {
            currentQuestion = Random.Range(0, QnA.Count);
            questionText.text = QnA[currentQuestion].question;
            setAnswers();
        }
        else
        {
            Debug.Log("Out Of Questions");
            gameOver();
        }
        
    }

}
