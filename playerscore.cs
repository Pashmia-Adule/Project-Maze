using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscore : MonoBehaviour
{
    
    int hits = 0;

void OnCollisionEnter(Collision other)
{
if(other.gameObject.tag != "Hit")
{
hits++;
Debug.Log("You bumped into a wall this many times: " + hits);
}
}

}
