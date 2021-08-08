using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScoopCollision : MonoBehaviour
{
    public GameObject FullScoop;
    public GameObject mixturePrefab;
	public GameObject bowl;
    Vector3 scoopPosition;
    Vector3 bowlPosition;
	Vector3 mixturePosition;
	Vector3 ogPositionBawl;
	Vector3 ogPositionscoop;

	private void Start()
    {
		//ogPosition = scoop.transform.position;
		ogPositionBawl = bowl.transform.position;
		ogPositionscoop = FullScoop.transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bowl")
        {
			scoopPosition = FullScoop.transform.position;
            Destroy(bowl);
            Instantiate(mixturePrefab, ogPositionBawl, Quaternion.identity);
        }
    }
}
