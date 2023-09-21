using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsGenerator : MonoBehaviour
{
    [SerializeField] private Coin _coinTemplate;

    //[SerializeField] private GameObject _coinTemplate;

    void Start()
    {
        Coin createdCoin = Instantiate(_coinTemplate, new Vector3(800, 280, -220), Quaternion.identity);

        Debug.Log(createdCoin.Amount);
    }

    //void Start()
    //{
    //    GameObject createdCoin = Instantiate(_coinTemplate, new Vector3(800, 280, -220), Quaternion.identity);

    //    Debug.Log(createdCoin.GetComponent<Coin>().Amount);
    //}
}
