using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 5f;

    void Update()
    {
        transform.Translate(0,projectileSpeed * Time.deltaTime,0);
    }
}
