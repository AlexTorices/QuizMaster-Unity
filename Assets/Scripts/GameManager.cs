using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endScreen;

    private void Awake() {
        quiz = FindAnyObjectByType<Quiz>();
        endScreen = FindAnyObjectByType<EndScreen>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowQuizScreen();
    }

    void ShowQuizScreen(){
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    void ShowEndScreen(){
        quiz.gameObject.SetActive(false);
        endScreen.gameObject.SetActive(true);
        endScreen.ShowFinalScore();
    }

    // Update is called once per frame
    void Update()
    {
        if(quiz.isComplete){
            ShowEndScreen();
        }
    }

    public void OnReplayLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
