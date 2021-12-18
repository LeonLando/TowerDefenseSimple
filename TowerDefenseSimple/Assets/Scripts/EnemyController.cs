using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float Speed;  //Скорость врага
    public Transform[] WayPoints;  //Массив точек для передвижения
    [SerializeField] private int CurrentWayPointIndex = 0; //Индекс точки к которой движется враг
    public bool Died = false;
    



    void Update()
    {
        if (!Died)
        {
            if (CurrentWayPointIndex < WayPoints.Length)
            {
                transform.position = Vector3.MoveTowards(transform.position, WayPoints[CurrentWayPointIndex].position, Time.deltaTime * Speed); //Передвижение к точке
                transform.LookAt(WayPoints[CurrentWayPointIndex].position); //Поворот лицом к точке
                if (Vector3.Distance(transform.position, WayPoints[CurrentWayPointIndex].position) < 0.5f)
                {
                    CurrentWayPointIndex++; //Смена точки
                }
            }
            if (true)
            {

            }
        }
        
        
    }
}
