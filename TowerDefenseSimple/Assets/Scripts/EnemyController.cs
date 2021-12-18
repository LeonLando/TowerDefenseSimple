using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float Speed;  //�������� �����
    public Transform[] WayPoints;  //������ ����� ��� ������������
    [SerializeField] private int CurrentWayPointIndex = 0; //������ ����� � ������� �������� ����
    public bool Died = false;
    



    void Update()
    {
        if (!Died)
        {
            if (CurrentWayPointIndex < WayPoints.Length)
            {
                transform.position = Vector3.MoveTowards(transform.position, WayPoints[CurrentWayPointIndex].position, Time.deltaTime * Speed); //������������ � �����
                transform.LookAt(WayPoints[CurrentWayPointIndex].position); //������� ����� � �����
                if (Vector3.Distance(transform.position, WayPoints[CurrentWayPointIndex].position) < 0.5f)
                {
                    CurrentWayPointIndex++; //����� �����
                }
            }
            if (true)
            {

            }
        }
        
        
    }
}
