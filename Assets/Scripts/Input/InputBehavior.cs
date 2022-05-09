using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehavior : MonoBehaviour
{

    private PlayerMovement _playerMovement;

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
    }
}
