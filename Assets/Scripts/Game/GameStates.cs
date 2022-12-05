/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File GameStates.cs : File that stores the game's states.
 */

namespace Game
{
    public class GameStates
    {
        protected static ZClicker ZGameInstance;

        public GameStates(ZClicker zGame)
        {
            ZGameInstance = zGame;
        }

        public enum GameStateType
        {
            GamePlaying,
            GameWaiting,
            GameEnd
        }

        public virtual void OnStateEnter() { }
        public virtual void OnStateExit() { }
        public virtual void OnStateUpdate() { }
    }
}
