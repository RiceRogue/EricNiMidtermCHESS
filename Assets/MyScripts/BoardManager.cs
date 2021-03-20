using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{

    public GameObject player1;
    
    public GameObject enemy;
    public GameObject WallLight;
    public GameObject WallDark;

    public bool wallNotSpawned;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(enemy, new Vector3(5, 5, 5), enemy.transform.rotation);
        wallNotSpawned = false;
    }


    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(10, 11);
        Physics.IgnoreLayerCollision(9, 11);


        //creates random x,y,z values for the enemy to spawn in. 




        if (wallNotSpawned == false)
        {
            
            //Random generation for walls
            for (int i = 0; i < Random.Range(5, 12); i++)
            {
                float rand_x = Random.Range(2f, 18f);
                float rand_y = Random.Range(2f, 5f);
                float rand_z = Random.Range(2f, 18f);

                int lightdark = Random.Range(0, 2);
                if (lightdark == 0)
                {
                    GameObject wall = Instantiate(WallLight, new Vector3(rand_x, 1.3f, rand_z), WallLight.transform.rotation);

                    //Check if the spawned wall is overlapping any other colliders, be it boxes or players or enemies, if it is it will move it. 
                    if(Physics.CheckBox(wall.transform.position, new Vector3(0.85f,0.85f,0.85f), wall.transform.rotation) == true)
                    {
                        float rand_x2 = Random.Range(2f, 18f);
                        float rand_y2 = Random.Range(2f, 5f);
                        float rand_z2 = Random.Range(2f, 18f);
                        wall.transform.position = new Vector3(rand_x2, 1.3f, rand_z2);
                       
                    }
                }

                if (lightdark == 1)
                {
                    GameObject wall =  Instantiate(WallDark, new Vector3(rand_x, 1.3f, rand_z), WallLight.transform.rotation);
                    if(Physics.CheckBox(wall.transform.position, new Vector3(0.85f, 0.85f, 0.85f), wall.transform.rotation) == true)
                    {

                        float rand_x2 = Random.Range(2f, 18f);
                        float rand_y2 = Random.Range(2f, 5f);
                        float rand_z2 = Random.Range(2f, 18f);
                        wall.transform.position = new Vector3(rand_x2, 1.3f, rand_z2);
                        
                    }
                }
            }

            wallNotSpawned = true;
        }




    }
}
