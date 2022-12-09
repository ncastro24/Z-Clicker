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

        public string ReturnCurrentGameType()
        {
            return currentState.ToString();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
