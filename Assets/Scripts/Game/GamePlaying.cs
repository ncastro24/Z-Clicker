/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File GamePlaying.cs : The game's playing state
 */

using GUI;

namespace Game
{
    public class GamePlaying : GameStates
    {
        public GamePlaying(ZClicker zGame) : base(ZGameInstance) { }

        public override void OnStateEnter()
        {
            
        }

        public override void OnStateExit()
        {
            //When The Game Exits GameEnd, add the requisite functions
        }
    }
}
