using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private int _health;

    public int Health 
    {
        get {return _health; }
        set {_health = value; }
    }
    
    public virtual void OnDeath()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    _health--;
        //}

        //If health reaches 0 
        if (_health <= 0)
        {
            //destroy the game object
            OnDeath();
        }


    }
}
