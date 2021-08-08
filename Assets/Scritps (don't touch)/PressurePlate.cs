using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject ppButton;
    bool pressed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        ppButton.GetComponent<PPMove>().descend();
    }

    private void OnTriggerExit(Collider other)
    {
        ppButton.GetComponent<PPMove>().ascend();
    }
}
