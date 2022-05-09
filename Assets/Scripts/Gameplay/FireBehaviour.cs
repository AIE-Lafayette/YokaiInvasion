using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    [SerializeField]
    private ProjectitleBehaviour _bulletRef;
    [SerializeField]
    private float _bulletForce;

    //Spawns a bullet and gives it a force 
    public void Fire()
    {
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        ProjectitleBehaviour bulletBehaviour = bullet.GetComponent<ProjectitleBehaviour>();
        bulletBehaviour.RigidBody.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
    }
}
