using System;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.transform.position.y < -3 )
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           Destroy(gameObject);
        }
    }
}
