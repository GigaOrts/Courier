using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smoothSpeed = 0.01f;

    private void LateUpdate()
    {
        var targetPosition = _target.position + _offset;
        var smoothedPosition = Vector3.Lerp(transform.position, targetPosition, _smoothSpeed);
        transform.position = smoothedPosition;
    }
}
