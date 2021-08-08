using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sail : MonoBehaviour
{
    Rigidbody rb;

    public GameObject snapPoint;
    public GameObject trigger;

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
        if (other.tag == "Sail Snap")
        {
            //gameObject.GetComponent<PickUp>().letGo();
            gameObject.transform.SetPositionAndRotation(snapPoint.transform.position, snapPoint.transform.rotation);
            rb.isKinematic = true;
            gameObject.tag = "Untagged";
        }
    }
}
