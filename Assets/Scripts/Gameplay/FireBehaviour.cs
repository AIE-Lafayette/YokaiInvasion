using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    [SerializeField]
    private ProjectitleBehaviour _bulletRef;
    
    [SerializeField]
    private float _bulletForce;
    private ProjectitleBehaviour bulletBehaviour;
    /// <summary>
    /// makes the bullet not hit the owner to kill its self
    /// </summary>
    [SerializeField]
    private GameObject _owner;

    public float BulletForce
    {
        get { return _bulletForce; }
    }

    private void Awake()
    {
        bulletBehaviour = GetComponent<ProjectitleBehaviour>();
    }
    //Spawns a bullet and gives it a force 
    public void Fire()
    {
        //instatiats the bullet and the position that it spawns, and its rotation.
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        ProjectitleBehaviour bulletBehaviour = bullet.GetComponent<ProjectitleBehaviour>();
        bulletBehaviour.OwnerTag = _owner.tag;
        //adds force to the rigidbody
        bulletBehaviour.RigidBody.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
    }
}
