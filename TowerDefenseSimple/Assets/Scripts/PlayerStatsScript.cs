using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsScript : MonoBehaviour
{
    public int Gold = 10;
    public int Lives = 3;
    [SerializeField] private Text GoldText;
    [SerializeField] private Text LivesText;

    void Start()
    {
        
    }

    void Update()
    {
        GoldText.text = Gold.ToString();
        LivesText.text = Lives.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Lives--;
            Destroy(other.gameObject);
        }
    }
}
