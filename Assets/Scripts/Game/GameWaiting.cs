/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File GameWaiting.cs : The game's waiting state
 */

//using GUI;

namespace Game
{
    public class GameWaiting : GameStates
    {
        public GameWaiting(ZClicker zGame) : base(ZGameInstance) { }

        public override void OnStateEnter()
        {

        }

        public override void OnStateExit()
        {
            //When The Game Exits GameEnd, add the requisite functions
        }
    }
}
