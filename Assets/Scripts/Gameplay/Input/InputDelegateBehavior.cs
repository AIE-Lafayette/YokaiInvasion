using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputDelegateBehavior : MonoBehaviour
{
    public static InputDelegateBehavior Instatce;
    private PlayerControls _playerControls;
    private PlayerMovementBehavior _playerMovement;
    [SerializeField]
    private FireBehaviour _gun;
    private bool _ableToGetInput = true;
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
        if (_ableToGetInput)
        {
            _playerControls.Player.Shoot.performed += context => _gun.Fire();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            Vector2 moveDirection = _playerControls.Player.Movement.ReadValue<Vector2>();
            _laneChange = moveDirection.x;
            _numberOfHits++;
            if (_numberOfHits == 4)
            {
                _playerMovement.Move((int)(_laneChange));

                _numberOfHits = 0;
            }
        //_playerControls.Player.Movement.activeControl.
    }
    public void Disable() 
    {
        _ableToGetInput = false;
        //Instatce.enabled = false;
       // this.enabled = false;
    }
    public void Enable()
    {
        _ableToGetInput = true;
       // Instatce.enabled = true;
       // this.enabled = true;
    }
}
