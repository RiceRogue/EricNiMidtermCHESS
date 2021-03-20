using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    //This class contains the functions for enemy health and pathfinding movements.
    public int enemyHealth;
    public bool destroyed;



    void Start()
    {
        enemyHealth = 20;
        destroyed = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (enemyHealth <= 0)
        {


            
            destroyed = true;
            Destroy(gameObject);

        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {

            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();

            player.playerHealth -= 5;
            player.GetComponent<AudioSource>().Play();

        }
    }

}
