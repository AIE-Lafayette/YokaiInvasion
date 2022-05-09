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
    private GameObject bullet;

    private void Awake()
    {
        bulletBehaviour = GetComponent<ProjectitleBehaviour>();

    }
    //Spawns a bullet and gives it a force 
    public void Fire()
    {
        //instatiats the bullet and the position that it spawns, and its rotation.
        bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
       //adds force to the rigidbody
        bulletBehaviour.RigidBody.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
    }
}
