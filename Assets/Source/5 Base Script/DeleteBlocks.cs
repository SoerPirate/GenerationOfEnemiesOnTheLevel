using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{
    private void Start()
    {
        // var camera = GameObject.FindObjectOfType<Camera>();

        GameObject block = GameObject.Find("Block");

        Destroy(block);

        GameObject[] blocks = GameObject.FindGameObjectsWithTag("BlockToDelete");

        foreach (var item in blocks)
        {
            //Destroy(item);

            item.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    private void Update()
    {
        
    }
}
