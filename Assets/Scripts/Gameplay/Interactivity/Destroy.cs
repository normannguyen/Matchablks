using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float lifeTime = 10f;

    private void Update()
    {
        if(lifeTime>0)
        {
            lifeTime -= Time.deltaTime;
            if(lifeTime<=0)
            {
                Destruction();
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "destroyer")
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
