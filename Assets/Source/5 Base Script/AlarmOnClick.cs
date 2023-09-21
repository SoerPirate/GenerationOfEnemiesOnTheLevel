using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmOnClick : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    private void OnMouseDown()          // ����� BoxCollider 
    {
        _animator.SetTrigger("Alarm");
    } 
}
