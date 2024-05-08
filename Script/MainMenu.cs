using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()//Inica el juego clikeando el boton de jugar
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    public void QuitGame()//se cierra el juego apretando el boton de quit
    {
        Application.Quit();
    }
}
