using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonCollision : MonoBehaviour
{
    public GameObject scoop;
    public GameObject myPrefab;
    Vector3 scoopPosition;
    Vector3 ogPosition;

    private void Start()
    {
        //ogPosition = scoop.transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "alginate")
        {
            scoopPosition = scoop.transform.position - new Vector3 (0f,0f,0.6f);
            Destroy(scoop);
            Instantiate(myPrefab, scoopPosition, Quaternion.identity);
        }
    }
}
