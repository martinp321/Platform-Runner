using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour
{
    public static float distanceTraveled;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(5f * Time.deltaTime, 0f, 0f);
        distanceTraveled = transform.localPosition.x;
        transform.Translate(Input.acceleration.x, 0f, -Input.acceleration.y);
    }
}
