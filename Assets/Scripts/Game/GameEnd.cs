/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File GameEnd.cs : The game's end state
 */

//using GUI;

namespace Game
{
    public class GameEnd : GameStates
    {
        public GameEnd(ZClicker zGame) : base(ZGameInstance) { }

        public override void OnStateEnter()
        {
            Timer.EndGame();
        }

        public override void OnStateExit()
        {
            //When The Game Exits GameEnd, add the requisite functions
        }
    }
}
