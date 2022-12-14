/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File Countdown.cs : Countdown before starting game. 
 */

using System.Collections;
using Game;
//using Player;
using UnityEngine;
using UnityEngine.UI;

    public class Countdown : ZClicker
    {
        private int countdownFromNum = 4;
        public Text countdownText;

        private IEnumerator CountingDown()
        {
            int counter = countdownFromNum;
            while (counter >= 0)
            {
                yield return new WaitForSeconds(1);
                counter--;
                countdownText.text = counter.ToString();
            }
            countdownText.text = "START";
            yield return new WaitForSeconds(1);
            //PlayerMovement.enableMove();
            Destruction();
        }

        private void Destruction()
        {
            NewGameState(GameStates.GameStateType.GamePlaying);
            countdownText.text = "";
        }
    }
