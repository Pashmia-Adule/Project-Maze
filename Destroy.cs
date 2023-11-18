using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check for input or any condition you want to use to trigger destruction
        if (Input.GetKeyDown(KeyCode.J))
        {
            Destroy(gameObject); // Destroy the current GameObject this script is attached to
        }
    }
}



