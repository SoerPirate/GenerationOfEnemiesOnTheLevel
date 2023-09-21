using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowedLerp : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _target;

    [SerializeField] private float _pathTime;
    [SerializeField] private float _pathRunningTime;

    public void Update()
    {
        //_pathRunningTime += Time.deltaTime;

        _target.position = Vector2.Lerp(_target.position, _b.position, 0.01f);  // Можно использовать Vector3   

        //_target.position = Vector2.Lerp(_target.position, _b.position, _pathRunningTime);  // Можно использовать Vector3   
    }
}
