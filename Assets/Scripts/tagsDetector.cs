using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagsDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Object")
        // By using {}, the condition apply to that entire scope, instead of the next line.
        {
            print("You got science");  
        }
        else
        {
            print("Sorry, wrong block");
        }
    }
}
