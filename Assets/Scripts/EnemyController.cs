using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;

    void Start()
    {
        InvokeRepeating(nameof(EnemyFire), 0.5f, 0.5f);
    }

    void Update()
    {
        
    }

    private void EnemyFire()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
