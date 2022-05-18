using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenuBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameManager _gamemanger = GameManager.Instace;
    public GameObject ExitMenu;
    void Awake()
    {

        GameManager.OnGmaeStateChange += GameManager_OnGmaeStateChange;
    }

    private void GameManager_OnGmaeStateChange(GameState obj)
    {

    }

    void OnDestroy()
    {
        GameManager.OnGmaeStateChange -= GameManager_OnGmaeStateChange;
    }
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
