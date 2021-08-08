using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixtureCollision : MonoBehaviour
{
    GameObject bottle;
    // Start is called before the first frame update
    private void Start()
    {
       bottle = GameObject.Find("waterbottle");
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "waterbottle")
        {
           Destroy(bottle);
        }
    }
}
