using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour
{
    float movementSpeed;
    float horiMovement; 
    float vertMovement; 
    
     

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 2;
         
    }

    // Update is called once per frame
    void Update()
    {
        horiMovement = Input.GetAxis("Horizontal");
        vertMovement = Input.GetAxis ("Vertical");

        transform.Translate(horiMovement * Time.deltaTime * movementSpeed,0,0);
        transform.Translate(0,0,vertMovement * Time.deltaTime * movementSpeed);

        transform.Translate(horiMovement * Time.deltaTime * movementSpeed, 0, vertMovement * Time.deltaTime * movementSpeed);

    

    }
}
