using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Cubo : MonoBehaviour
{
    public Transform alvo;
    public List<Transform> targetList;

    Vector3 startPosCubo1 = new Vector3(0, 0, 0);
    Vector3 endPos;
    Transform target;

    [Range(0.001f, 10.0f)]
    public float lerpTime = 5;
    private float currentlerpTime = 0;
    public int index = 0;

    private void Update()
    {

        
        if(index > targetList.Count)
        {
            index = 0;
        }
        target = targetList[index];
        endPos = target.position;

        if(this.transform.position == target.position)
        {
            index++;
            currentlerpTime = 0;
            startPosCubo1 = this.transform.position;
        }

        currentlerpTime += Time.deltaTime;
        if (currentlerpTime >= lerpTime)
        {
            currentlerpTime = lerpTime;
        }
        float lerpSpeed = currentlerpTime / lerpTime;
        this.transform.position = Vector3.Lerp(startPosCubo1, endPos, lerpSpeed);

    }
}
