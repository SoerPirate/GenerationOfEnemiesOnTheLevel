using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _pauseBetweenSpawn = 2.0f;

    private SpawnPoint[] _spawners;

    private WaitForSeconds _waitForSeconds;

    private Coroutine _spawnJob;

    private bool _start = false;

    private void Awake()
    {
        _spawners = GetComponentsInChildren<SpawnPoint>();

        _waitForSeconds = new WaitForSeconds(_pauseBetweenSpawn);
    }

    private void Start()
    {
        StartSpawn();  
    }

    private void StartSpawn()
    {
        _spawnJob = StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int value = Random.Range(0, _spawners.Length);

        _spawners[value].SpawnEnemy();

        yield return _waitForSeconds;

        StartSpawn();
    }
}