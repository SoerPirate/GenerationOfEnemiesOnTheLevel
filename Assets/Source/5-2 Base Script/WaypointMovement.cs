using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;

    [SerializeField] private Transform[] _points;

    [SerializeField] private float _speed;

    private int _currentPoint;              //   Почему по умолчанию = 1 ?

    private void Start()
    {
        // _points = _path.GetComponentsInChildren<Transform>();

        _points = new Transform[_path.childCount];

        for (int i = 0; i < _points.Length; i++)
        {
            _points[i] = _path.GetChild(i);

            //_points[i] = _path.GetChild(i).transform;
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }

        //var direction = (target.position - transform.position).normalized;
        //transform.position += direction * Time.deltaTime;

        //if ((target.position - transform.position).magnitude < 0.15f)
        //{
        //    transform.position = target.position;

        //    _currentPoint++;

        //    if (_currentPoint >= _points.Length)
        //    {
        //        _currentPoint = 0;
        //    }
        //}
    }
}
