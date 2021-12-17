using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    [SerializeField] private Transform ShootElement;   //Элемент из которого вылетают снаряды
    [SerializeField] private Transform LookAtObj;  //Элемент поворачивающийся к цели
    [SerializeField] private GameObject Bullet;  //Префаб снаряда
    [SerializeField] private float Damage;   //Урон от снаряда
    [SerializeField] private float ShootSpeed; //Скорость снаряда 
    public Transform Target; //Цель
    [SerializeField] private float ShootDelay; //Промежуток между выстрелами
    [SerializeField] private bool IsShoot;  //Буль на выстрел
    


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
