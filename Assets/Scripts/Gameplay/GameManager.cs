using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private GameObject[] _enemies;
    private EnemySpawnerBehavior enemySpawnerBehavior;
    private EnemyBehaviour _enemyBehaviour;
    public Text _enemycount;
    [SerializeField]
    private float MaxHealth;
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
            if (_enemyBehaviour.Health <= MaxHealth)
                _enemyBehaviour.Health += 2;
            //spawn the next wave here 
            //when the spawn the the next wave hapens the stats increase
            //or decrease here
            //new script for the sides moving here
            return;
        }
    }

}
