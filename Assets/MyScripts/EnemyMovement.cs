using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    //This class contains the functions for enemy health and pathfinding movements.
    public int enemyHealth;
    public bool destroyed;

    public NavMeshAgent agent;

    
    void Start()
    {
        enemyHealth = 20;
        destroyed = false;
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updatePosition = false;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (enemyHealth <= 0)
        {
            

           
             destroyed = true;
             Destroy(gameObject);
            
        }

        GameObject player = GameObject.Find("White King");

        if (destroyed == false)
        {
            agent.destination = player.transform.position;
            
            //transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0, 90, 0, 0), Time.deltaTime * 1);

        }



    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {

            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
            
               player.playerHealth -= 5;
            

        }
    }





}
