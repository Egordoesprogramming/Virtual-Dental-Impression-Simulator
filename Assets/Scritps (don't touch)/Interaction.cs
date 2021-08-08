using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject interactionHitbox;
    public GameObject holdingPoint;
    bool holdingOject;
    private PickUp box;
    bool justPickedUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingOject && !justPickedUp)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                print("Could you let me down?");
                box.letGo();
                box = null;
                holdingOject = false;
            }
        }

        justPickedUp = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (!holdingOject)
        {
            if (other.tag == "Pick up")
            {
                print("I can press E to pick you up");

                if (Input.GetKeyUp(KeyCode.E))
                {
                    print("I want to pick you up :]");

                    holdingOject = true;
                    box = other.GetComponent<PickUp>();
                    box.grab(holdingPoint);
                    justPickedUp = true;
                }
            }

            else if (other.tag == "Button")
            {
                print("Press the button");

                if (Input.GetKeyUp(KeyCode.E))
                {
                    other.GetComponent<Button>().activate();
                }
            }
            
            else if (other.tag == "Lever")
            {
                print("Pull the lever, Kronk");

                if (Input.GetKeyUp(KeyCode.E))
                {
                    other.GetComponent<Lever>().pull();
                }
            }
        }
    }
}
