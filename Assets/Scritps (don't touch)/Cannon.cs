using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    Rigidbody rb;

    public GameObject trigger;
    public GameObject otherCannon;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cannon Snap")
        {
            //gameObject.GetComponent<PickUp>().letGo();
            otherCannon.GetComponent<MeshCollider>().enabled = true;
            otherCannon.GetComponent<MeshRenderer>().enabled = true;

            gameObject.transform.position = new Vector3(0, -5, 0);

            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<MeshCollider>().enabled = false;
            //Destroy(this.gameObject);
        }
    }
}
