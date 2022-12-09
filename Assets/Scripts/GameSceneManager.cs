/*
    name:  Nayeli Castro
    ID:   2340374
    email: ncastro@chapman.edu
    class:  CPSC-245-1 
    title:  Final: "Z-Clicker" 
 Source File GameSceneManager.cs : File to manage scenes of the game.
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public string mainmenu;
    public string game;
    public string endscreen;

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainmenu);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(game);
    }

    public static void LoadEndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }


}
