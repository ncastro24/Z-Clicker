/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File AchievementManager.cs : Handles the kinds of achievements in the game.
 Reference: https://www.youtube.com/watch?v=8cFCyIP2LYM
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public static List<Achievement> achievements;

    //public int score = ScoreKeeper.GetScore();
    public int score;

    public bool AchievementUnlocked(string achievementName)
    {
        bool result = false;

        if (achievements == null)
            return false;

        Achievement[] achievementsArray = achievements.ToArray();
        Achievement a = Array.Find(achievementsArray, ach => achievementName == ach.title);

        if (a == null)
            return false;

        result = a.achieved;

        return result;
    }

    private void Start()
    {
        InitializeAchievements();
    }

    public void ScoreVal()
    {
        score = ScoreKeeper.GetScore();
    }

    private void InitializeAchievements()
    {
        if (achievements != null)
            return;

        achievements = new List<Achievement>();
        achievements.Add(new Achievement("On a Roll", "Press Z 10 times!", (object o) => score == 10));
        achievements.Add(new Achievement("On a Bread", "Press Z 20 times!", (object o) => score == 20));
        achievements.Add(new Achievement("On a Bagel", "Press Z 50 times!", (object o) => score == 50));
        achievements.Add(new Achievement("Rolled too Far", "Press Z 100 times!", (object o) => score == 100));
    }

    private void Update()
    {
        CheckAchievementCompletion();
        ScoreVal();
    }

    private void CheckAchievementCompletion()
    {
        if (achievements == null)
            return;

        foreach (var achievement in achievements)
        {
            achievement.UpdateCompletion();
        }
    }
}

public class Achievement
{
    public Achievement(string title, string description, Predicate<object> requirement)
    {
        this.title = title;
        this.description = description;
        this.requirement = requirement;
    }

    public string title;
    public string description;
    public Predicate<object> requirement;

    public bool achieved;

    public void UpdateCompletion()
    {
        if (achieved)
            return;

        if (RequirementsMet())
        {
            Debug.Log($"{title}: {description}");
            achieved = true;
        }
    }

    public bool RequirementsMet()
    {
        return requirement.Invoke(null);
    }
}
