using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawCollision : MonoBehaviour
{
	public GameObject cast;
	private Vector3 finalCastPos = new Vector3(5.0f, 3.9f, 2.7f);

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "filledTopTray1")
		{
			Instantiate(cast, finalCastPos, Quaternion.Euler(0, 180, 0));
		}
	}
}