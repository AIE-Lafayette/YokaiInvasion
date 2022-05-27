using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTagSkripBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _PowerUps;
    public string[] PowerUpNumbers;
    // Start is called before the first frame update
    void Start()
    {
        _PowerUps.tag = PowerUpNumbers[Random.Range(0,2)];
    }
}