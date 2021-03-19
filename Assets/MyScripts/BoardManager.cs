using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{

    public GameObject player1;
    
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(enemy, new Vector3(5, 5, 5), enemy.transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(10, 11);

        //creates random x,y,z values for the enemy to spawn in. 





    }
}
