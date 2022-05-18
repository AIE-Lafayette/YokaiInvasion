using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenuBehaviour : MonoBehaviour
{
   
    public GameObject ExitMenu;
    // Start is called before the first frame update
    void Start()
    {
        ExitMenuButton();
    }

    public void RestartButton()
    {
        GameManager.Instace.UpdateGamestate(GameState.Startmenu);
        //go back a scene
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ExitMenuButton()
    {
        ExitMenu.SetActive(true);
    }
    public void QuitButton()
    {
        //leave
        Application.Quit();
    }
}
