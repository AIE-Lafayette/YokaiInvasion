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

    private bool _isMoving;
    private bool _isShooting;
    public bool IsShooting { get => _isShooting; }

    public bool IsMoving {get => _isMoving; }

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

        _isMoving = _playerControls.Player.Movement.activeControl.IsPressed();

        _isShooting = _playerControls.Player.Shoot.activeControl.IsPressed();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsMoving)
            return;

        if (IsShooting)
            _isShooting = true;
        else
            _isShooting = false;

        Vector2 moveDirection = _playerControls.Player.Movement.ReadValue<Vector2>();
        _laneChange = moveDirection.x;
        _numberOfHits++;
        if(_numberOfHits == 4)
        {
            _playerMovement.Move((int)(_laneChange));

            _numberOfHits = 0;
        }
        //_playerControls.Player.Movement.activeControl.

    }
}
