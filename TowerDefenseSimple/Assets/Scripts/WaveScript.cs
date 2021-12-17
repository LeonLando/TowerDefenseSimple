using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{
    public int WaveSize; //���-�� ������ � �����
    [SerializeField] private GameObject EnemyPref; //������ �����
    [SerializeField] private float EnemyInterval; //�������� ��������� �������
    [SerializeField] private Transform SpawnPoint; //����� ������ ��������
    public float StartWaveTime; //����� �� ������ ���������
    [SerializeField]  private int EnemyCount; //������� ����������� ��������
    public Transform[] WayPoints; //������ ����� ��� ������������

    void Start()
    {
        InvokeRepeating("SpawnEnemy", StartWaveTime, EnemyInterval); //��������� ������������ ������ ��� ��������� ��������
    }

    void Update()
    {
        if (EnemyCount == WaveSize)
        {
            CancelInvoke("SpawnEnemy"); //������ ��������� �������� ��� ���������� ���-�� WaveSize
        }
    }

    void SpawnEnemy()
    {
        EnemyCount++;
        GameObject Enemy = GameObject.Instantiate(EnemyPref, SpawnPoint.position, Quaternion.identity) as GameObject; //�������� ������� �� ����� ������
        Enemy.GetComponent<EnemyController>().WayPoints = WayPoints; //�������� ������ ����� ��� �������� �������
    }
}
