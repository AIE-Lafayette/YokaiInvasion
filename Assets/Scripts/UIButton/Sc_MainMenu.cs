using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sc_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    // Start is called before the first frame update
    void Start(){ MainMenuButton();}

    //increases the sene by 1
    public void PlayNowButton() {GameManager.Instace.UpdateGamestate(GameState.SpawnWave);}

    public void MainMenuButton()  { MainMenu.SetActive(true);}
    //leaves the game and close application
    public void QuitButton() {/*leave*/ Application.Quit();}
}
