using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        EnemyMovement enemy = collision.gameObject.GetComponent<EnemyMovement>();

        if (collision.gameObject.tag == "Enemy")
        {

            enemy.enemyHealth -= 5;

        }


    }

}
