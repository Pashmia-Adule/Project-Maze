using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

   void OnCollisionEnter(Collision other)
{
if(other.gameObject.tag == "Player" ){

 GetComponent<MeshRenderer>().material.color = Color.yellow;
gameObject.tag = "Hit";
StartCoroutine(ResetColorAfterDelay(1.5f)); // Reset color after 1.5 seconds 
        }
    }

    IEnumerator ResetColorAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        GetComponent<MeshRenderer>().material.color = Color.cyan; // Reset the color back to the original color
        gameObject.tag = "Untagged"; // Reset the tag if needed
   
}
}