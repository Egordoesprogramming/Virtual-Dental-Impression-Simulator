using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollision : MonoBehaviour
{

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "practiceHead")
		{
			Destroy(this.gameObject);
		}
	}
}

