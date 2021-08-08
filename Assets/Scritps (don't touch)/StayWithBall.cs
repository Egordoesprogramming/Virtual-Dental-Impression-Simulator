using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayWithBall : MonoBehaviour
{
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = ball.transform.position;
    }
}
