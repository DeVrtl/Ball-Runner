using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private Transform[] _spawnPoints;
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

            GameObject spawnPrefab = _prefabs[Random.Range(0, _prefabs.Length)];
            Transform currentPointSpawn = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

            Instantiate(spawnPrefab, currentPointSpawn);
        }
    }
}
