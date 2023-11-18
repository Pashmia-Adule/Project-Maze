using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour{

   bool isitColliding;
void Start()
{
isitColliding = false;
 }

    //This is where I would like code to be per frame (Happen again and again).
 void Update()
{

if(isitColliding == false){
transform.position += new Vector3(2 *Time.deltaTime,0, 0);

}
 
 if(isitColliding == true){

 transform.position += new Vector3(-2 *Time.deltaTime,0, 0); 

 }
 }

void OnCollisionEnter(Collision other) {
 
 if(other.gameObject.tag == "WallSouth" && isitColliding == false){
isitColliding = true;
transform.position += new Vector3(0,0, 0); 

 }

if(other.gameObject.tag == "WallNorth" && isitColliding == true){
isitColliding = false;
transform.position += new Vector3(0,0, 0); 


 }
 }

}
