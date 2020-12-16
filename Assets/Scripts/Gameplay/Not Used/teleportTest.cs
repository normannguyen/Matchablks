using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class teleportTest : MonoBehaviour

{

    public Transform teleportTarget;

    public GameObject thePlayer;



    void OnTriggerEnter()

    {

        thePlayer.transform.position = teleportTarget.transform.position;

    }

}