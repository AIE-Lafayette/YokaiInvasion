using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class ExitMenuBehaviour : MonoBehaviour
{
    public GameObject ExitMenu;
    public PlayerControls _playerinput;
    public InputDelegateBehavior InputDelegateBehavior;
    // Start is called before the first frame update
    void Start() {ExitMenuButton();}
    public void RestartButton() {GameManager.Instace.UpdateGamestate(GameState.MainGameScene);}
    public void ExitMenuButton() {ExitMenu.SetActive(true);}
    public void QuitButton() {/*leave*/ Application.Quit();}

    private void Update()
    {
        if (_playerinput.Player.Start.activeControl.IsPressed())
            RestartButton();
        if (_playerinput.Player.Exit.activeControl.IsPressed())
            QuitButton();
    }
}
