using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public int objectLimit;
    public int maxLimit;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }
    //void Limit()
    //{
    //    spawnee += objectLimit
    //    if (objectLimit <= maxLimit)
    //    {

    //    }
    //}
}
