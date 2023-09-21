using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]                                             // требует обязательно этот компонент на объекте 

public class Example : MonoBehaviour
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    private void OnValidate()                       // срабатывает при изменении параметра в инспекторе 
    {
        if (_minValue >= _maxValue)
            _minValue = _maxValue - 1;
    }
}
