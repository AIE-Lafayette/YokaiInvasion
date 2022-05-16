using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sc_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    //increases the sene by 1
    public void PlayNowButton()
    {
        //go forward a scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenuButton() 
    {
        MainMenu.SetActive(true);
    }
    //leaves the game and close application
    public void QuitButton()
    {
        //leave
        Application.Quit();
    }
}
