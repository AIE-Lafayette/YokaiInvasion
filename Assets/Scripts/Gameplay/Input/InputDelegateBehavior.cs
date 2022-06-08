using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputDelegateBehavior : MonoBehaviour
{
    private PlayerControls _playerControls;
    private PlayerMovementBehavior _playerMovement;
    [SerializeField]
    private FireBehaviour _gun;

    private float _laneChange;
    private float _numberOfHits;

    private void Awake()
    {
        _playerControls = new PlayerControls();
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerControls.Player.Shoot.performed += context => _gun.Fire();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 moveDirection = _playerControls.Player.Movement.ReadValue<Vector2>();
        _laneChange = moveDirection.x;
        _numberOfHits++;
        //sets an artificial timer in order to slow down the movement of the player.
        if(_numberOfHits == 3)
        {
            _playerMovement.Move((int)(_laneChange));

            //Reset this number every time this function is called.
            _numberOfHits = 0;
        }

        
        //_playerControls.Player.Movement.activeControl.
        
    }
}
