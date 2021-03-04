using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Scene1Cubo : MonoBehaviour
{
    Vector3 StartPos = new Vector3(0, 0, 0);
    Vector3 EndPos = new Vector3(0, -100, 0);

    public float lerpTime = 5;
    private float currentlerpTime = 0;

    private void Update()
    {
        currentlerpTime += Time.deltaTime;
        if (currentlerpTime >= lerpTime)
        {
            currentlerpTime = lerpTime;
        }
        float speedLerp = currentlerpTime / lerpTime;
        this.transform.position = Vector3.Lerp(StartPos, EndPos, speedLerp);
    }
}
