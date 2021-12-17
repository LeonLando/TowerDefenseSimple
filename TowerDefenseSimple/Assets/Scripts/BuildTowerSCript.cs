using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTowerSCript : MonoBehaviour
{
    [SerializeField] private GameObject Tower;
    [SerializeField] private GameObject CurrentTower;
    [SerializeField] private bool EmptyPoint = true;
    [SerializeField] private GameObject SpawnTowerPoint;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (EmptyPoint)
        {
            CurrentTower = GameObject.Instantiate(Tower, SpawnTowerPoint.transform.position , Quaternion.identity) as GameObject;
            EmptyPoint = false;
        }
    }
}
