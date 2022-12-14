/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File GameStates.cs : Stores the game's main functionalities.
 */

//using GUI;
using UnityEngine;

namespace Game
{
    public class ZClicker : MonoBehaviour
    {
        public GameStates GameStates;
        public static GamePlaying GamePlaying;
        public static GameWaiting GameWaiting;
        public static GameEnd GameEnd;

        protected static GameStates.GameStateType currentState;

        public Timer Timer;
        public static Countdown Countdown;

        public string ReturnCurrentGameType()
        {
            return currentState.ToString();
        }

        void Awake()
        {
            GamePlaying = new GamePlaying(this);
            GameWaiting = new GameWaiting(this);
            GameEnd = new GameEnd(this);
            Timer = GetComponent<Timer>();
            Countdown = GetComponent<Countdown>();
        }
        void Start()
        {
            currentState = GameStates.GameStateType.GameWaiting;
            NewGameState(GameStates.GameStateType.GameWaiting);
        }
        public static void NewGameState(GameStates.GameStateType newState)
        {
            GamePlaying.OnStateExit();
            GameWaiting.OnStateExit();
            GameEnd.OnStateExit();
            currentState = newState;
            switch (currentState)
            {
                case GameStates.GameStateType.GamePlaying:
                    GamePlaying.OnStateEnter();
                    break;
                case GameStates.GameStateType.GameWaiting:
                    GameWaiting.OnStateEnter();
                    break;
                case GameStates.GameStateType.GameEnd:
                    GameEnd.OnStateEnter();
                    break;
            }
        }
        public static GameStates.GameStateType GetCurrentState()
        {
            return currentState;
        }
    }
}
