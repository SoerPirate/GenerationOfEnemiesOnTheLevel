using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExample : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _target;

    public void SetNormalizedPosition(float position)
    {
        _target.position = Vector2.Lerp(_a.position, _b.position, position);  // Можно использовать Vector3  

        //_target.position = Vector2.Lerp(_target.position, _b.position, position);  
    }
}
