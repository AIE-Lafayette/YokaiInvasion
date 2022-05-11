using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private GameObject[] _enemies;
    private EnemySpawnerBehavior enemySpawnerBehavior;
    public Text _enemycount;

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

        //if the start timer is greater than or equal to the max timer 
        if (_enemies.Length == 0 )
        {
            //spawn the next wave here 
            
            return;
        }
    }

}
