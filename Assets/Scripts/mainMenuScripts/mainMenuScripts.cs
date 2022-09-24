using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[System.Serializable]
public class mainMenuScripts : MonoBehaviour
{
    public 
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void closeGameButton()
    {
        Application.Quit();
    }

    public void startGameButton()
    {
        SceneManager.LoadScene("gameScene");
    }

}
