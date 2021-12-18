using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject TowerChoice;
    // Start is called before the first frame update
    void Start()
    {
        TowerChoice = GameObject.FindGameObjectWithTag("Shop");
        TowerChoice.SetActive(true);
    }

   
    void Update()
    {
        if (Input.GetKeyDown("Space"))
        {
            TowerChoice.SetActive(false);
        }
    }
}
