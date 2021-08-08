using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traycollision : MonoBehaviour
{
	private GameObject tray1;
	private GameObject tray2;
	public GameObject fullTrayPrefab1;
	public GameObject fullTrayPrefab2;
	Vector3 fullTray1Position;
	Vector3 fullTray2Position;


	private void Start()
	{
		//ogPosition = scoop.transform.position;
		tray1 = GameObject.Find("tray1");
		tray2 = GameObject.Find("tray2");
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "tray1")
		{
			fullTray1Position = tray1.transform.position;
			Destroy(tray1);
			Instantiate(fullTrayPrefab1, fullTray1Position, Quaternion.identity);
		}

		if (collision.gameObject.name == "tray2")
		{
			fullTray2Position = tray2.transform.position;
			Destroy(tray2);
			Instantiate(fullTrayPrefab2, fullTray2Position, Quaternion.identity);
		}

	}
}

