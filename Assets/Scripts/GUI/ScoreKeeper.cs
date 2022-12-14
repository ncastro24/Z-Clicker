/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File ScoreKeeper.cs : File to manage scores of the game.
 */

using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private static int score = 0;

    public Text ScoreText;
    public static string printScore = "Score: 0";

    private void Update()
    {
        ScoreText.text = printScore;
    }

    public static void AddToScore(int amount)
    {
        score += amount;
        printScore = "Score: " + score;
    }

    public static int GetScore()
    {
        return score;
    }
    public static void ResetScore()
    {
        score = 0;
        printScore = "Score: 0";
    }

    public static void EndScore()
    {
        int final = score;
        printScore = final + " ";
    }
}
