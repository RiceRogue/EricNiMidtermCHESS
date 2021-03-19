using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float followSpeed;
    
    public Camera cam;

    public Rigidbody rigidbody;

 
    
    
    //public BoardManager manager;
    // Start is called before the first frame update
    void Start()
    {
        followSpeed = 5f;
        rigidbody = gameObject.GetComponent<Rigidbody>();
        //manager = gameObject.AddComponent<BoardManager>();
        cam = Camera.main;
        
        
    }

    // Update is called once per frame
    void Update()
    {


        //This helps control the player's movement. 
        //https://gamedevacademy.org/unity-3d-first-and-third-person-view-tutorial //[

        
        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        




        //Code from Nimso Ny's tutorial on moving the player relative to the camera. https://www.youtube.com/watch?v=ORD7gsuLivE 
        Vector3 camForward = cam.transform.forward;
        Vector3 camRight = cam.transform.right;

        camForward.y = 0;
        camRight.y = 0;
        camForward = camForward.normalized;
        camRight = camRight.normalized;

        //using transform position does not have as good of collisions, so I am using the movement from Rigidbody instead. 
        //transform.position += ((camForward * z + camRight * x) * Time.deltaTime * followSpeed);
        rigidbody.AddForce((camRight*x + camForward*z)* followSpeed );

        //]




    }
}
