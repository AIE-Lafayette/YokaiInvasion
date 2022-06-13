using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    [SerializeField]
    private ProjectitleBehaviour _bulletRef;
    public static FireBehaviour instance;
    [SerializeField]
    private float _bulletForce;
    private ProjectitleBehaviour bulletBehaviour;

    /// <summary>
    /// makes the bullet not hit the owner to kill its self
    /// </summary>
    [SerializeField]
    private GameObject _owner;
    /// <summary>
    /// it the total force that the bullet gives off
    /// </summary>
    public float BulletForce
    {
        get { return _bulletForce; }
    }
    /// <summary>
    /// decreases the damage of the bullet
    /// </summary>
    /// <param name="ForceDecrease">is the amount that it is decreased</param>
    /// <returns></returns>
    public virtual float ForceNerf(float ForceDecrease)
    {
        _bulletForce -= ForceDecrease;

        return ForceDecrease;
    }

    private void Awake()
    {
        instance = this;
        bulletBehaviour = GetComponent<ProjectitleBehaviour>();
    }

    //Spawns a bullet and gives it a force 
    public void Fire()
    {
        _bulletRef.transform.forward = transform.forward;
        //instatiats the bullet and the position that it spawns, and its rotation.
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        ProjectitleBehaviour bulletBehaviour = bullet.GetComponent<ProjectitleBehaviour>();
        bulletBehaviour.OwnerTag = _owner.tag;
        //adds force to the rigidbody
        bulletBehaviour.RigidBody.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
    }
}
