using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]                                             // требует обязательно этот компонент на объекте 

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private ContactFilter2D _contactFilter2D;

    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody2D;
    
    private Animator _animator;

    private readonly RaycastHit2D[] _results = new RaycastHit2D[16];

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        var collisionCount = _rigidbody2D.Cast(transform.right, _contactFilter2D, _results, 100); 

        if (collisionCount == 0)
        {
            _animator.SetFloat("Speed", _speed);

            _rigidbody2D.velocity = _speed * transform.right;
        }
        else
        {
            _animator.SetFloat("Speed", 0);
        }
    }
}
