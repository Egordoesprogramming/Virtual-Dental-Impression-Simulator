using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour
{
    public PPMove pp;

    bool up;

    public GameObject upPos;
    public GameObject downPos;

    Vector3 currentPos;

    float percentage = 0;

    float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        up = pp.getActivated();

        if (!up)
        {
            percentage -= Time.deltaTime * speed;
        }

        else
        {
            percentage += Time.deltaTime * speed;
        }

        percentage = Mathf.Max(0, Mathf.Min(1f, percentage));

        currentPos.y = (1 - percentage) * downPos.transform.position.y + percentage * upPos.transform.position.y;

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, currentPos.y, gameObject.transform.position.z);
    }
}
