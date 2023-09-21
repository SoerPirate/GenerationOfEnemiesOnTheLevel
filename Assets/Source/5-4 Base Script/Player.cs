using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Block>(out Block block)) 
        {
            _hit?.Invoke();
        }

        //if (collision.collider.TryGetComponent<EndPoint>(out EndPoint endPoint))
        //{
        //    Debug.Log("PunchTrigger");
        //    _animator.SetTrigger("PunchTrigger");
        //}
    }
}
