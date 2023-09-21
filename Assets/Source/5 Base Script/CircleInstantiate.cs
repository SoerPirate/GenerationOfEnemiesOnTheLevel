using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject _template;

    [SerializeField] private int _count;

    [SerializeField] private float _radius;

    private void Start()
    {
        int angleStep = 360 / _count;

        for (int i = 0; i < _count; i++)
        {
            GameObject newObject = Instantiate(_template, Vector3.zero, Quaternion.identity);
            newObject.GetComponent<SpriteRenderer>().color = Color.red;

            Transform newObjectTransform = newObject.GetComponent<Transform>();

            newObjectTransform.position = new Vector3(_radius * Mathf.Cos(angleStep * (i + 1) * Mathf.Deg2Rad), _radius * Mathf.Sin(angleStep * (i + 1) * Mathf.Deg2Rad));
        }
    }

    private void Update()
    {

    }
}
