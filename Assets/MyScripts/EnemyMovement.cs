using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    //This class contains the functions for enemy health and pathfinding movements.
    

    public NavMeshAgent agent;
    public bool isDestroyed;

    
    void Start()
    {
        isDestroyed = gameObject.transform.GetChild(0).GetComponent<EnemyHealth>().destroyed;
        agent = gameObject.GetComponent<NavMeshAgent>();
        //agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("White King");

        if (isDestroyed == false)
        {
            agent.SetDestination( player.transform.position);
            
            //transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0, 90, 0, 0), Time.deltaTime * 1);

        }
        agent.SetDestination(player.transform.position);


    }


    





}
