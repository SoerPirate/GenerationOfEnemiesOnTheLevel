using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        
    }

    private void Update()
    {
        //Debug.Log(Input.GetKey(KeyCode.D));
        
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        
        //Debug.Log(Input.GetKey(KeyCode.A));
        
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(_speed * Time.deltaTime * - 1, 0, 0);
        }
    }
}
