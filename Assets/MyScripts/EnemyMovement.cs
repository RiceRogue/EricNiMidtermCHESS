using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    //This class contains the functions for enemy health and pathfinding movements.
    public int enemyHealth;
    void Start()
    {
        enemyHealth = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


    


}
