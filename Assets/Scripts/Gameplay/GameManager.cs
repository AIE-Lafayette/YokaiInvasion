using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private GameObject[] _enemies;
    private EnemySpawnerBehavior enemySpawnerBehavior;
    public Text _enemycount;
    /// <summary>
    /// is the start of the spawn
    /// </summary>
    [SerializeField]
    private float StartTimerForSpawn;
    /// <summary>
    /// is the compared time that start timer has to reach
    /// </summary>
    [SerializeField]
    private float MaxTimerForSpawn;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //is the game object has the tag enemy
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //then print the text 
        _enemycount.text = "Enemies: " + _enemies.Length.ToString();
        //add deltatime to the start timer
        StartTimerForSpawn += Time.deltaTime;
        //if the start timer is greater than or equal to the max timer 
        if (StartTimerForSpawn >= MaxTimerForSpawn )
        {
            //spawn the next wave here 
            
            return;
        }
    }

}
