using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private GameObject[] _enemies;
    public Text _enemycount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");
        _enemycount.text = "Enemies: " + _enemies.Length.ToString();
    }

}
