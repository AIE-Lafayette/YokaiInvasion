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
    // Update is called once per frame
    void Update()
    {
        RoutineBehaviour.Instance.StartNewTimedAction(args => Destroy(this), TimedActionCountType.UNSCALEDTIME, _lifeTime );
        
    }
}
