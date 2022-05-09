using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehavior : MonoBehaviour
{

    private PlayerMovement _playerMovement;
    [SerializeField]
    //private FireBehaviourScript _gun;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //new Vector3(Input.GetAxisRaw("Horizontal")
        _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0).normalized;

        //throws a projectitle when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //_gun.Fire();
        }
    }
}
