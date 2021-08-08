using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlCollision : MonoBehaviour
{
    public GameObject bowl;
    public GameObject mixBowl;
	public GameObject spatula;
    Vector3 bowlPosition;


	private void Start()
	{
		bowlPosition = bowl.transform.position - new Vector3 (0f,1f,0f);

	}

	void OnCollisionEnter(Collision collision)
    {
		if (collision.gameObject.tag == "Interactable")
		{
			if (collision.gameObject.name == "scoopFull(Clone)")
			{
				Destroy(bowl);
				Instantiate(mixBowl, bowlPosition/*new Vector3(0,0,0)*/, Quaternion.identity);
				print("collision works");
			}

		}
    }
}
