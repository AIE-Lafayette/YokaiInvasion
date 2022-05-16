using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private EnemySpawnerBehavior enemySpawnerBehavior1;

    private EnemyBehaviour _enemyBehaviour;
    public Text _enemycount;
    [SerializeField]
    private float HealthLimit;

    // Update is called once per frame
    void Update()
    {
        //then print the text 
        _enemycount.text = "Enemies: " + enemySpawnerBehavior1.EnemyCount.ToString();
        //if the start timer is greater than or equal to the max timer 
        if (enemySpawnerBehavior1.EnemyCount <= 0)
        {
            //max health is less than the health limit 
            if (_enemyBehaviour.MaxHealth <= HealthLimit)
                _enemyBehaviour.MaxHealth += 2;//plus 2 to max health *or decrease here*
        }
    }
}