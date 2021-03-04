using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Cubo : MonoBehaviour
{
    public GameObject cubo2;
    public Transform alvo;

    Vector3 startPosCubo1 = new Vector3(0, 0, 0);
    Vector3 startPosCubo2 = new Vector3(100, -100, 0);
    Vector3 endPosCubo1; //= new Vector3(0, -100, 0);
    Vector3 endPosCubo2; //= new Vector3(0, -100, 0);

    Vector3 startPosAlvo = new Vector3(0, -100, 0);
    Vector3 endPosAlvo = new Vector3(-150, -50, 0);

    [Range(0.001f, 10.0f)]
    public float lerpTime = 5;
    [Range(0.001f, 5.0f)]
    public float alvolerpTime = 2;
    private float currentlerpTime = 0;

    private void Update()
    {
        endPosCubo1 = alvo.position;
        endPosCubo2 = alvo.position;

        currentlerpTime += Time.deltaTime;
        if (currentlerpTime >= lerpTime)
        {
            currentlerpTime = lerpTime;
        }
        float lerpSpeed = currentlerpTime / lerpTime;
        this.transform.position = Vector3.Lerp(startPosCubo1, endPosCubo1, lerpSpeed);
        cubo2.transform.position = Vector3.Lerp(startPosCubo2, endPosCubo2, lerpSpeed);
        alvo.position = Vector3.Lerp(startPosAlvo, endPosAlvo, lerpSpeed * alvolerpTime);

    }
}
