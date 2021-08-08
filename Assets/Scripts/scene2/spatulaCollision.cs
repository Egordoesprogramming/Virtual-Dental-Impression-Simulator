using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spatulaCollision : MonoBehaviour
{
	public GameObject spatula;
	public GameObject fullSpatulaPrefab;
	Vector3 spatulaFullPosition;
	

	private void Update()
	{
		if (spatula.activeInHierarchy == true)
		{
			spatulaFullPosition = spatula.transform.position;
		}
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "mixture")
		{	
			Destroy(spatula);
			Instantiate(fullSpatulaPrefab, spatulaFullPosition, Quaternion.identity);
		}
	}
}
