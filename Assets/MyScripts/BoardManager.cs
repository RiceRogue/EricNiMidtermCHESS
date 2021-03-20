using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BoardManager : MonoBehaviour
{

    public GameObject player1;
    
    public GameObject enemy;
    public GameObject WallLight;
    public GameObject WallDark;



    //level determines the number of enemies spawned.
    public int level;
    //public GameObject wall;

    public bool wallNotSpawned;
    public TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        //Instantiate(enemy, new Vector3(5, 5, 5), enemy.transform.rotation);
        wallNotSpawned = false;
        scoreText.text = "LEVEL: " + level;
    }


    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(10, 11);
        Physics.IgnoreLayerCollision(9, 11);


        //creates random x,y,z values for the enemy to spawn in. 

        if (wallNotSpawned == false)
        {
            generateWalls();
            spawnEnemies();
            wallNotSpawned = true;
        }

        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            foreach(GameObject g in GameObject.FindGameObjectsWithTag("Wall"))
            {
                Destroy(g);
            }

            level += 1;
            scoreText.text = "LEVEL: " + level;
            generateWalls();
            spawnEnemies();
        }

    }

    public void spawnEnemies()
    {
        for(int i = 0; i < level; i++)
        {
            float rand_x = Random.Range(2f, 18f);
            float rand_y = Random.Range(2f, 5f);
            float rand_z = Random.Range(2f, 18f);
            if (Physics.CheckBox(enemy.transform.position, new Vector3(1f, 1f, 1f), enemy.transform.rotation) == true)
            {
                Instantiate(enemy, new Vector3(rand_x, rand_y, rand_z), enemy.transform.rotation);
            }

        }
        
        
    }
    public void generateWalls()
    {
        //Random generation for walls
        for (int i = 0; i < Random.Range(8, 19); i++)
        {
            float rand_x = Random.Range(2f, 18f);
            float rand_y = Random.Range(2f, 5f);
            float rand_z = Random.Range(2f, 18f);

            int lightdark = Random.Range(0, 2);
            if (lightdark == 0)
            {
                GameObject wall = Instantiate(WallLight, new Vector3(rand_x, 1.3f, rand_z), WallLight.transform.rotation);

                //Check if the spawned wall is overlapping any other colliders, be it boxes or players or enemies, if it is it will move it. 
                if(Physics.CheckBox(wall.transform.position, new Vector3(0.85f, 0.85f, 0.85f), wall.transform.rotation) == true)
                {
                    float rand_x2 = Random.Range(2f, 18f);
                    float rand_y2 = Random.Range(2f, 5f);
                    float rand_z2 = Random.Range(2f, 18f);
                    wall.transform.position = new Vector3(rand_x2, 1.3f, rand_z2);

                }
            }

            if (lightdark == 1)
            {
                GameObject wall = Instantiate(WallDark, new Vector3(rand_x, 1.3f, rand_z), WallLight.transform.rotation);
                if(Physics.CheckBox(wall.transform.position, new Vector3(0.85f, 0.85f, 0.85f), wall.transform.rotation) == true)
                {

                    float rand_x2 = Random.Range(2f, 18f);
                    float rand_y2 = Random.Range(2f, 5f);
                    float rand_z2 = Random.Range(2f, 18f);
                    wall.transform.position = new Vector3(rand_x2, 1.3f, rand_z2);
                }
            }
        }

    }

    
}
