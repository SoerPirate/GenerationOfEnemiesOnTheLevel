using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    private void Awake()                                            // работает даже если компонент отключен в сцене
    {
        Debug.Log("[" + Time.time + "] Awake - " + gameObject.name);
    }
    
    private void OnEnable()
    {
        Debug.Log("[" + Time.time + "] OnEnable - " + gameObject.name);
    }   
    
    private void OnDisable()
    {
        Debug.Log("[" + Time.time + "] OnDisable - " + gameObject.name);
    }

    private void Start()
    {
        Debug.Log("[" + Time.time + "] Start - " + gameObject.name);
    }

    private void Update()
    {
        Debug.Log("Update - " + gameObject.name);
        //Debug.Log("[" + Time.time + "] Update - " + gameObject.name);
    }
}
