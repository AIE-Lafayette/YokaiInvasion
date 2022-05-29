using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _enviromentRef;
    [SerializeField]
    private float _lifeTime;
    private float _timer;
    private Transform _setPostion;
    private void Start()
    {
        _setPostion = _enviromentRef.transform;
         
    }
    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _enviromentRef.SetActive(true);
        //destroys the enviroment after some time
        if (_timer >= _lifeTime)
        {
            ReastPlace();
        }
           // Destroy(_enviromentRef);

    }

    void ReastPlace() 
    {
        _enviromentRef.transform.position = _setPostion.position;
        _enviromentRef.SetActive(false);
    }
}
