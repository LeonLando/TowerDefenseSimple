using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{
    public int WaveSize; //Кол-во врагов в волне
    [SerializeField] private GameObject EnemyPref; //Префаб врага
    [SerializeField] private float EnemyInterval; //Интервал появления префаба
    [SerializeField] private Transform SpawnPoint; //Точка спавна префабов
    public float StartWaveTime; //Время до начала появления
    [SerializeField]  private int EnemyCount; //Счетчик появившихся префабов
    public Transform[] WayPoints; //Массив точек для передвижения

    void Start()
    {
        InvokeRepeating("SpawnEnemy", StartWaveTime, EnemyInterval); //Активация зацикленного метода для появления префабов
    }

    void Update()
    {
        if (EnemyCount == WaveSize)
        {
            CancelInvoke("SpawnEnemy"); //Отмена появления префабов при достижении кол-ва WaveSize
        }
    }

    void SpawnEnemy()
    {
        EnemyCount++;
        GameObject Enemy = GameObject.Instantiate(EnemyPref, SpawnPoint.position, Quaternion.identity) as GameObject; //Создание префаба на точке спавна
        Enemy.GetComponent<EnemyController>().WayPoints = WayPoints; //Передача нужных точек для движения префабу
    }
}
