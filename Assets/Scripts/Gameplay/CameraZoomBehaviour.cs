using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CameraZoomBehaviour : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private Vector2 _referenceAspectRatio;
    private Vector3 _startPos;
    private float _refRatio;
    [SerializeField]
    private Vector3 _zoomScale = Vector3.one;
    // Start is called before the first frame update
    void Start()
    {
        //this is the camer
        _camera = GetComponent<Camera>();
        //divides the aspect ratios x by its y
        _refRatio = _referenceAspectRatio.x / _referenceAspectRatio.y;
        //make the start pos to the transofrm position
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if the aspect ratio's x is lest than 0 or is y is less than 0
        if (_referenceAspectRatio.x <= 0 || _referenceAspectRatio.y <= 0)
            return;//return

        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);
        //scales the product of startpos and the ratio with the zoomScale
        Vector3 scalePosition = Vector3.Scale(_startPos * (float)ratio, _zoomScale);
        //makes the local position equal to the scaled position
        transform.localPosition = scalePosition;
    }
}
