using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float Speed;
    public Transform Target;
    public TowerController Tower;
    [SerializeField] private GameObject Bullet;
    void Start()
    {
        
    }

    void Update()
    {
        if (Target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.position, Time.deltaTime * Speed);
        }
        else
        {
            Destroy(Bullet);
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform == Target)
        {
            Target.GetComponent<EnemyHealthSCript>().Damage(Tower.Damage);
            Destroy(Bullet);
        }
    }
}
