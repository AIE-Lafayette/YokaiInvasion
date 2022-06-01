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
        RoutineBehaviour.Instance.StartNewTimedAction(args => ReastPlace(), TimedActionCountType.UNSCALEDTIME, _lifeTime );
    }

    void ReastPlace() 
    {
       _enviromentRef.gameObject.SetActive(false);
        _enviromentRef.transform.position = _setPostion.position;
    }
}
