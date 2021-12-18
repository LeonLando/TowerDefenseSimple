using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    [SerializeField] private Transform ShootElement;   //������� �� �������� �������� �������
    [SerializeField] private Transform LookAtObj;  //������� ���������������� � ����
    public GameObject Bullet;  //������ �������
    public int Damage = 10;   //���� �� �������
    [SerializeField] private float ShootSpeed; //�������� ������� 
    public Transform Target; //����
    [SerializeField] private float ShootDelay; //���������� ����� ����������
    [SerializeField] private bool IsShoot;  //���� �� �������
    


    void Start()
    {
        
    }

    void Update()
    {
        if (Target)
        {
            LookAtObj.transform.LookAt(Target);
            if (IsShoot != true)
            {
                StartCoroutine(Shoot());
            }
        }
       


    }

    IEnumerator Shoot()
    {
        IsShoot = true;
        yield return new WaitForSeconds(ShootDelay);
        GameObject B = GameObject.Instantiate(Bullet, ShootElement.position, Quaternion.identity) as GameObject;
        B.GetComponent<BulletScript>().Target = Target;
        B.GetComponent<BulletScript>().Tower = this;
        IsShoot = false;
    }
}
