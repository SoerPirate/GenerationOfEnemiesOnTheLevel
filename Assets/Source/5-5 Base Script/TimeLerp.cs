using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLerp : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _target;

    [SerializeField] private float _pathTime;
    [SerializeField] private float _pathRunningTime;

    public void Update()
    {
        _pathRunningTime += Time.deltaTime;

        _target.position = Vector2.Lerp(_a.position, _b.position, _pathRunningTime / _pathTime);  // Можно использовать Vector3
    }
}
