using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnerHolder : MonoBehaviour
{
    public static EnvironmentSpawnerHolder Instace;
    [SerializeField]
    private EnviromentBehavior[] _enviromentRef;

    private void Awake() { Instace = this; }
    // Update is called once per frame
    /// <summary>
    /// set the game objects to be active after the tiemr is done
    /// </summary>
    public void setActiveSpawners()
    {
        RoutineBehaviour.Instance.StartNewTimedAction(args => SetObjectToActive(), TimedActionCountType.UNSCALEDTIME, 1);
        RoutineBehaviour.Instance.StartNewTimedAction(args => SetObjectToActives(), TimedActionCountType.UNSCALEDTIME, 2);
       
    }

    void SetObjectToActive()
    {
        for (int i = 0; i < 2; i++)
        {
            _enviromentRef[i].gameObject.SetActive(true);
        }
    }
    void SetObjectToActives()
    {
        for (int i = 2; i < 4; i++)
        {
            _enviromentRef[i].gameObject.SetActive(true);
        }
        RoutineBehaviour.Instance.StartNewTimedAction(args => GameManager.Instace.UpdateGamestate(GameState.SpawnWave), TimedActionCountType.UNSCALEDTIME, 2);
    }
}
