using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]                                             // ������� ����������� ���� ��������� �� ������� 

public class Example : MonoBehaviour
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    private void OnValidate()                       // ����������� ��� ��������� ��������� � ���������� 
    {
        if (_minValue >= _maxValue)
            _minValue = _maxValue - 1;
    }
}
