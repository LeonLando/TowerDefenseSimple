using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    [SerializeField] private Transform ShootElement;   //������� �� �������� �������� �������
    [SerializeField] private Transform LookAtObj;  //������� ���������������� � ����
    [SerializeField] private GameObject Bullet;  //������ �������
    [SerializeField] private float Damage;   //���� �� �������
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
        IsShoot = false;
    }
}
