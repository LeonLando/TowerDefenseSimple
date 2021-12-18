using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildTowerScript : MonoBehaviour
{
    [SerializeField] private GameObject SimpleTower;
    [SerializeField] private GameObject CurrentTower;
    [SerializeField] private bool EmptyPoint = true;
    [SerializeField] private GameObject SpawnTowerPoint;
    [SerializeField] private GameObject PlayerStats;
    


    void Start()
    {
        PlayerStats = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void OnMouseDown()
    {
        if (EmptyPoint && PlayerStats.GetComponent<PlayerStatsScript>().Gold >= 30)
        {
            CurrentTower = GameObject.Instantiate(SimpleTower, SpawnTowerPoint.transform.position, Quaternion.identity) as GameObject;
            PlayerStats.GetComponent<PlayerStatsScript>().Gold -= 30;
            EmptyPoint = false;
        }
    }
}
