using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollision : MonoBehaviour
{
    //This class takes care of collisions only. 
    public bool swordMoving;
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
        if (collision.gameObject.tag == "Enemy")
        {

            EnemyHealth enemyRook = collision.gameObject.GetComponent<EnemyHealth>();
            if (swordMoving == true)
            {
                GetComponent<AudioSource>().Play();
                enemyRook.enemyHealth -= 5;

            }

        }
    }
}


    

