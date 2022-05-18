using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sc_MainMenu : MonoBehaviour
{
    [SerializeField]
   private GameManager _gamemanger = GameManager.Instace;
    public GameObject MainMenu;
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
        MainMenuButton();
    }

    //increases the sene by 1
    public void PlayNowButton()
    {
        //go forward a scene
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameManager.Instace.UpdateGamestate(GameState.SpawnWave);
       // _gamemanger.UpdateGamestate(GameState.EndScreen);

       //GameManager.Instace.UpdateGamestate(GameState.EndScreen);
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
