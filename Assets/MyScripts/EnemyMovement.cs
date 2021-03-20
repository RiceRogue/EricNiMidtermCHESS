using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    //This class contains the functions for enemy health and pathfinding movements.
    public int enemyHealth;
    public bool destroyed;
    void Start()
    {
        enemyHealth = 20;
        destroyed = false;
        gameObject.GetComponent<NavMeshAgent>().updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(90, 0, 0, 0), Time.deltaTime * 1) ;
        if (enemyHealth <= 0)
        {
            

           
             destroyed = true;
             Destroy(gameObject);
            
        }

        GameObject player = GameObject.Find("White King");

        if (destroyed == false)
        {
            GetComponent<NavMeshAgent>().destination = player.transform.position;
        }

    }





}
