using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVert : MonoBehaviour
{
float moveSpeedOne;
float moveSpeedTwo;
bool isitSo;

    // Start is called before the first frame update
    void Start()
    {
 moveSpeedOne = 4f;
 moveSpeedTwo = 4f; 
 isitSo = true;
 
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(moveSpeedOne * Time.deltaTime, 0, 0);
 
 if(transform.position.x >= 0.61f){
moveSpeedOne = 0f;
isitSo = false;
moveSpeedTwo = -4f;
}

if(transform.position.x <=-4.83 ){
moveSpeedTwo = 0f;
isitSo = true;
moveSpeedOne = 4f; 
}



if (isitSo == false){
transform.Translate(moveSpeedTwo * Time.deltaTime, 0, 0);
}


    }
}
