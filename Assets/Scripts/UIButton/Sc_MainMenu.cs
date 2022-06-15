using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class Sc_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public PlayerControls _playerinput;
    public InputDelegateBehavior InputDelegateBehavior;
    // Start is called before the first frame update
    void Start(){ MainMenuButton();}
    //increases the sene by 1
    public void PlayNowButton() {GameManager.Instace.UpdateGamestate(GameState.MainGameScene);}
    public void MainMenuButton()  { MainMenu.SetActive(true);}
    //leaves the game and close application
    public void QuitButton() {/*leave*/ Application.Quit();}

    private void Update()
    {
        if (_playerinput.Player.Start.activeControl.IsPressed())
            PlayNowButton();
        if (_playerinput.Player.Exit.activeControl.IsPressed())
            QuitButton();
    }
}
