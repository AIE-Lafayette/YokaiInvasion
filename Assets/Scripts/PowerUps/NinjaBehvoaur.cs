using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NinjaBehvoaur : PowerUpBehavior
{
    [SerializeField]
    private float _damage;
    [SerializeField]
    private GameObject _leftSpawnPoint, _leftSpawnPoint2, _rightSpawnPoint, _rightSpawnPoint2, _player;

    [SerializeField]
    private InputDelegateBehavior _ninjaInput;

    private PlayerControls _playerControls;

    private bool _shoot;

    public bool Shoot { get => _shoot; set => _shoot = value; }

    public float Damage { get { return _damage; } set { _damage = value; } }

    private void Awake()
    {
        _playerControls = new PlayerControls();
    }
    // Update is called once per frame
    void Update()
    {
        if (this == null)
            return;
        RoutineBehaviour.Instance.StartNewTimedAction(args => ResetGameObject(), TimedActionCountType.UNSCALEDTIME, 10);

         _shoot = _playerControls.Player.Shoot.activeControl.IsPressed();
    }
    /// <summary>
    /// made boxes that the ninjas will go to when the collided with a wall.
    /// </summary>
    /// <param name="other">other is a wallLeft or Wall Right</param>
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "WallL")
        {
            if (tag == "NinjaL")
                transform.position = _rightSpawnPoint2.transform.position;
            if (tag == "NinjaR")
                transform.position = _rightSpawnPoint.transform.position; 
        }

        if (other.tag == "WallR")
        {
            if (tag == "NinjaL")
                transform.position = _leftSpawnPoint.transform.position;
            if (tag == "NinjaR")
                transform.position = _leftSpawnPoint2.transform.position; 
        }
    }
    /// <summary>
    /// Resets the posistion of the ninjas
    /// </summary>
    private void ResetGameObject()
    {
        if (gameObject.tag == "NinjaL")
            transform.position = _leftSpawnPoint.transform.position;
        if (gameObject.tag == "NinjaR")
            transform.position = _rightSpawnPoint.transform.position;
        gameObject.SetActive(false);
    }
}
