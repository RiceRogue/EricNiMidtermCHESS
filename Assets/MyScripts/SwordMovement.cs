using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sword;

    //splitting up the hands and sword did not work, so they were combined into one object.
    //public GameObject hands;
    private float swingTime;

    private float timer;
    
    //This class is responsible for spawning the hands and guilding the player's sword movement. 
    void Start()
    {
        //hands = Instantiate(hands, transform.position + transform.right, transform.rotation);
        sword = Instantiate(sword, transform.position, sword.transform.rotation);
        timer = 0f;
        swingTime = 1.0f;
       
        //sword.transform.SetParent(hands.transform);

        //check if the sword is moving, for different levels of movement from the swing. 
    }

    // Update is called once per frame
    void Update()
    {

        //Grabs the sword collision method to adjust the moving variable within it. 
        SwordCollision swordCollision = sword.GetComponent<SwordCollision>();


        //Sword orientation in relation to both the camera and the player. 

        sword.GetComponent<Rigidbody>().MovePosition(Vector3.Lerp(sword.transform.position,Camera.main.transform.position + 0.3f *
                Camera.main.transform.right + 1.7f * Camera.main.transform.forward, 50f*Time.deltaTime));
        

        //hands.transform.position = Camera.main.transform.position + 0.3f * Camera.main.transform.right + 0.9f * Camera.main.transform.forward;

        sword.transform.rotation = Camera.main.transform.rotation * new Quaternion(0.1f,5f,2.9f,0.9f);




        //Swings the sword the player has.
        if (Input.GetKey(KeyCode.Space))
        {
            swordCollision.swordMoving = true;
            if (timer < swingTime)
            {
                timer += Time.deltaTime;
                sword.transform.rotation = Camera.main.transform.rotation * new Quaternion(-2.2f, 1.5f, 4.9f, 1f);

                sword.transform.position = Vector3.Lerp(sword.transform.position, transform.position +
                     -0.5f * Camera.main.transform.right + 0.1f * Camera.main.transform.forward, 8f * Time.deltaTime);
            } else  {
                sword.transform.position = Vector3.Lerp(sword.transform.position, Camera.main.transform.position + 0.3f *
                Camera.main.transform.right + 1.7f * Camera.main.transform.forward, 8f * Time.deltaTime);
            }

        } else {
            timer = 0f;
            swordCollision.swordMoving = false;
        }


    }



    



}
