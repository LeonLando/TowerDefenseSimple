using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthSCript : MonoBehaviour
{
    [SerializeField] private GameObject PlayerStats;
    private bool GetRevard = false;
    public Animator Anim;
    public GameObject Enemy;
    public int CurrentHP = 30;

    private void Start()
    {
        PlayerStats = GameObject.FindGameObjectWithTag("Player");
        Anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (CurrentHP <= 0)
        {
            Enemy.GetComponent<EnemyController>().Died = true;
            Anim.SetBool("Die", true);
            if (!GetRevard)
            {
                Debug.Log("Get");
                PlayerStats.GetComponent<PlayerStatsScript>().Gold += 10;
                GetRevard = true;
            }
            
            
        }
    }

    public void Damage(int DamageCount)
    {
        CurrentHP -= DamageCount;
    }

    public void EnemyKill()
    {
        Destroy(Enemy);
    }
}
