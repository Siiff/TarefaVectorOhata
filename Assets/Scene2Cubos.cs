using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Cubos : MonoBehaviour
{
    public GameObject cubo2;          

    Vector3 startPosCubo1 = new Vector3(0, 0, 0);
    Vector3 startPosCubo2 = new Vector3(100, -100, 0);
    Vector3 endPosCubo1 = new Vector3(0, -100, 0);
    Vector3 endPosCubo2 = new Vector3(0, -100, 0);

    public float lerpTime = 5;
    private float currentlerpTime = 0;


    private void Update()
    {
        currentlerpTime += Time.deltaTime;
        if (currentlerpTime >= lerpTime)
        {
            currentlerpTime = lerpTime;
        }
        float Perc = currentlerpTime / lerpTime;
        this.transform.position = Vector3.Lerp(startPosCubo1, endPosCubo1, Perc);
        cubo2.transform.position = Vector3.Lerp(startPosCubo2, endPosCubo2, Perc);

    }
}
