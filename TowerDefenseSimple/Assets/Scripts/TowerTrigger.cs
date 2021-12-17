using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrigger : MonoBehaviour
{
    [SerializeField] private TowerController Tower;
    [SerializeField] private bool EnemyLock;
    [SerializeField] GameObject CurrentTarget;

    private void Update()
    {
        if (!CurrentTarget)
        {
            EnemyLock = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && EnemyLock == false)
        {
            Tower.Target = other.gameObject.transform;
            CurrentTarget = other.gameObject;
            EnemyLock = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy") && other.gameObject == CurrentTarget)
        {
            EnemyLock = false;
        }
    }
}
