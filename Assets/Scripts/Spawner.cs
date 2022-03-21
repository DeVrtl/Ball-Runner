using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Obstacle> _obstaclePrefabs;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime;

    private void OnValidate()
    {
        _secondsBetweenSpawn = Mathf.Clamp(_secondsBetweenSpawn, 0, float.MaxValue);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;

            Obstacle spawnPrefab = _obstaclePrefabs[UnityEngine.Random.Range(0, _obstaclePrefabs.Count)];
            Transform currentPointSpawn = _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)];

            Instantiate(spawnPrefab, currentPointSpawn);
        }
    }
}
