using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{

    public GameObject Checkerboard;
    // Start is called before the first frame update
    void Awake()
    {
        //generating the rows and columns of a 4x4 checkerboard piece.
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Instantiate(Checkerboard, new Vector3(i, 0, j), transform.rotation);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
}
