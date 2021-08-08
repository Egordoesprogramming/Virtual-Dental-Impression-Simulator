using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject button;
    public GameObject min;
    public GameObject max;
    bool down;
    bool activated;

    Vector3 maxHeight;
    Vector3 minHeight;

    float percentage;
    float currentPercentage;

    Vector3 currentPosition;

    ButtonRamp buttonRamp;

    // Start is called before the first frame update
    void Start()
    {
        activated = false;
        down = false;

        maxHeight = max.transform.position;
        minHeight = min.transform.position;

        percentage = 0;

        buttonRamp = FindObjectOfType<ButtonRamp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            percentage += Time.deltaTime;

            if (percentage < 0.5f)
            {
                currentPercentage = 1 - (percentage * 2);

                currentPosition.x = (1 - currentPercentage) * minHeight.x + currentPercentage * maxHeight.x;
                currentPosition.y = (1 - currentPercentage) * minHeight.y + currentPercentage * maxHeight.y;
                currentPosition.z = (1 - currentPercentage) * minHeight.z + currentPercentage * maxHeight.z;

            }

            else
            {
                if (percentage > 1.0f)
                {
                    percentage = 1.0f;
                    activated = false;
                }

                currentPercentage = (percentage - 0.5f) * 2;

                currentPosition.x = (1 - currentPercentage) * minHeight.x + currentPercentage * maxHeight.x;
                currentPosition.y = (1 - currentPercentage) * minHeight.y + currentPercentage * maxHeight.y;
                currentPosition.z = (1 - currentPercentage) * minHeight.z + currentPercentage * maxHeight.z;

            }

            button.transform.SetPositionAndRotation(currentPosition, button.transform.rotation);
        }
    }

    public void activate()
    {
        activated = true;
        down = true;
        percentage = 0.0f;
        buttonRamp.resetTimer();
    }
}
