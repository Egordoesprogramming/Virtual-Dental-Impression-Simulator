using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonRamp : MonoBehaviour
{
    float timer;
    float maxTimer;

    public GameObject ramp;
    public GameObject upPos;
    public GameObject downPos;

    public GameObject button;

    public TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        maxTimer = 25.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
            ramp.transform.position = upPos.transform.position;
            text.text = ((int)timer + 1).ToString();
        }
        else
        {
            timer = 0.0f;
            ramp.transform.position = downPos.transform.position;
            text.text = "";
        }
    }

    public void resetTimer()
    {
        timer = maxTimer;
    }
}
