using System;
using UnityEngine;

public class InstantiateRoads : MonoBehaviour
{
    [SerializeField] private GameObject _carriles = default;
    [SerializeField] private Transform _spawnPoint = default;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(_carriles, _spawnPoint.transform.position, Quaternion.identity);
            Destroy(gameObject, 3f);
        }
        
    }
}
