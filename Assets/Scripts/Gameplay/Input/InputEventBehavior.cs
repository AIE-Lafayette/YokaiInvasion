using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputEventBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMovement;
    [SerializeField]
    private FireBehaviour _gun;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _playerMovement.Move(context.ReadValue<Vector2>());
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        _gun.Fire();
    }
}
