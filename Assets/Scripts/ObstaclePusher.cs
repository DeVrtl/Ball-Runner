using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePusher : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnValidate()
    {
        _speed = Mathf.Clamp(_speed, 0, float.MaxValue);
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.back);
    }
}
