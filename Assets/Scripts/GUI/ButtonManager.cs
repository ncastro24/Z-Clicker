/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File ButtonManager.cs : File to manage what gets executed with buttons.
 */

using UnityEngine;

    public class ButtonManager : MonoBehaviour
    {
        //protected static GameStates.GameStateType currentState;
        public GameSceneManager gamescenemanager;

        public void OnStartClick()
        {
            gamescenemanager.LoadGame();
        }

        public void OnQuitClick()
        {
            gamescenemanager.QuitGame();
        }

        public void OnMenuClick()
        {
            gamescenemanager.LoadMainMenu();
        }

        public void OnZClick()
        {
            ScoreKeeper.AddToScore(1);
        }
    }
