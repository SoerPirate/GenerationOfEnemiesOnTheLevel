using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);

        //Debug.DrawRay(transform.position, Vector2.up * 10, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        Debug.DrawRay(transform.position, transform.up * 10, Color.red);

        if (hit && hit.collider.gameObject.tag != "Player")
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
