using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaBehvoaur : PowerUpBehavior
{
    [SerializeField]
    private float _damage;
    [SerializeField]
    private GameObject _leftSpawnPoint,_leftSpawnPoint2, _rightSpawnPoint,_rightSpawnPoint2, _player;
    public float Damage { get { return _damage; } set { _damage = value; } }
    // Update is called once per frame
    void Update()
    {
        if (this == null)
            return;
        RoutineBehaviour.Instance.StartNewTimedAction(args => ResetGameObject(), TimedActionCountType.UNSCALEDTIME, 10);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WallL")
        {
            if (tag == "NinjaL")
                transform.position = _rightSpawnPoint2.transform.position; //new Vector3(_rightSpawnPoint.transform.position, transform.position.y, transform.position.z);
            if (tag == "NinjaR")
                transform.position = _rightSpawnPoint.transform.position; //new Vector3(1, transform.position.y, transform.position.z);
        }

        if (other.tag == "WallR")
        {
            if (tag == "NinjaL")
                transform.position = _leftSpawnPoint.transform.position;//new Vector3(1, transform.position.y, transform.position.z);
            if (tag == "NinjaR")
                transform.position = _leftSpawnPoint2.transform.position; //new Vector3(1, transform.position.y, transform.position.z);
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
