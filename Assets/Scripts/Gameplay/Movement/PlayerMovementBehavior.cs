using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{

    public static PlayerMovementBehavior Instace;
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    private int _lane,_lanes;

    public float Speed
    {
        get { return _speed; }
        set { Speed = value; }
    }
    private void Awake()
    {
        Instace = this;
        _lanes = 2;
    }
    public Vector3 Velocity 
    {
        get { return _velocity; }
    }
    public virtual float IncreaseSpeed(float SpeedIncrease)
    {
        _speed += SpeedIncrease;

        return SpeedIncrease;
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(int _lane) 
    {
        _lanes += _lane;
        //using lerp, the player should switch between the lanes, lane 0 is all the way to the left, lane 4 is all the way to the right.
        switch(_lanes)
        {
            case 0:
                transform.position = Vector3.Lerp(transform.position, new Vector3(-5, transform.position.y, transform.position.z),
                    50 * Time.deltaTime);
                break;
            case 1:
                transform.position = Vector3.Lerp(transform.position, new Vector3(-2, transform.position.y, transform.position.z),
                    50 * Time.deltaTime);
                break;
            case 2:
                transform.position = Vector3.Lerp(transform.position, new Vector3(1, transform.position.y, transform.position.z),
                    50 * Time.deltaTime);
                break;
            case 3:
                transform.position = Vector3.Lerp(transform.position, new Vector3(4, transform.position.y, transform.position.z),
                    50 * Time.deltaTime);
                break;
            case 4:
                transform.position = Vector3.Lerp(transform.position, new Vector3(7, transform.position.y, transform.position.z),
                    50 * Time.deltaTime);
                break;
        }
      
       // _velocity = direction * _speed * Time.deltaTime;    
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        //_rigidbody.MovePosition(transform.position + _velocity);
    }
}
