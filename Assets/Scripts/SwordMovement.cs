using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sword;
    public GameObject hands;
    private float swingTime;
    //This class is responsible for spawning the hands and guilding the player's sword movement. 
    void Start()
    {
        //hands = Instantiate(hands, transform.position + transform.right, transform.rotation);
        //sword = Instantiate(sword, hands.transform.position, sword.transform.rotation);
        swingTime = 1.3f;
    }

    // Update is called once per frame
    void Update()
    {
        //sword.transform.position = hands.transform.position;
        //sword.transform.rotation = hands.transform.rotation;

        //Sword orientation in relation to both the camera and the player. 
        hands.transform.position = Camera.main.transform.position + 0.3f* Camera.main.transform.right + 0.9f*Camera.main.transform.forward;
        sword.transform.rotation = Camera.main.transform.rotation * new Quaternion(-1f,0.3f,0.5f,0.5f);


        //Swings the sword the player has.
        if (Input.GetKey(KeyCode.Space))
        {
            swingSword();
        }

    }


    public void swingSword()
    {
        float timer = 0f;
        timer += Time.deltaTime;

        if (timer < swingTime)
        {
            sword.transform.position = Camera.main.transform.forward;
        }
    }
}
