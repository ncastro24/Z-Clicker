/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File Timer.cs : Timer for the main game.
 */

using System.Collections;
using Game;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int countdownFromNum = 30;
    public Text timerText;
    private static bool isDisplayUpdating;
    private string printTime = "";

    public GameSceneManager gamescenemanager;

    void Start()
    {
        isDisplayUpdating = false;
    }

    private void Update()
    {
        if (isDisplayUpdating)
        {
            StartCoroutine("CountDownTimer");
            StartCoroutine("CountDowntoEnd");
        }
    }

    public void UpdateDisplay(float currentTime)
    {
        float seconds = currentTime;
        if (seconds <= 0)
        {
            printTime = "Time Remaining: 00";
        }
        else
        {
            printTime = $"Time Remaining: {seconds:00}";
        }

        timerText.text = printTime;
    }

    public static void StartCountDownTimer()
    {
        isDisplayUpdating = true;
    }

    private IEnumerator CountDownTimer()
    {
        isDisplayUpdating = false;
        int countSeconds = countdownFromNum;

        while (currentState == GameStates.GameStateType.GamePlaying && counting)
        {
            countSeconds--;
            UpdateDisplay(countSeconds);
            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator CountDowntoEnd()
    {
        yield return new WaitForSeconds(30f); //how long game takes
        counting = false;
        print("Got to finish countdown");
        StateSwitch();
    }

    public static void EndGame()
    {
        GameSceneManager.LoadEndScreen();
    }


    public static void StateSwitch()
    {
        ZClicker.NewGameState(GameStates.GameStateType.GameEnd);
        print("Countdown ended");
        ScoreKeeper.EndScore();
    }
}
