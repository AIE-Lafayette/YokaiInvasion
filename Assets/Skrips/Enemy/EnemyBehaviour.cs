using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float health;
    //this is waht the health is meant to be
    //private healthbehaviour _health;
    private Vector3 _distance;
    //this is the scaling to make the enemys health , damage, and speed
    [SerializeField]
    private float scaling;
    //This is to make the scaling limited so the enemy can not scaling infinitly.
    [SerializeField]
    private float scalingCap; 
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //if the next wave spawns \scaling/ gos up
        _distance = new Vector3(0, 0, -_speed);
        transform.position += _distance;

    }
}
