using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Transform refPointOne, refPointTwo;
    public float timeToDest;

    bool isForward = true;
    float curPercent;
    float curTime;

    public AnimationCurve moveCurve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curPercent = curTime / timeToDest;

        curPercent = moveCurve.Evaluate(curPercent);

        if(isForward)
        {
            transform.position = Vector3.Lerp(refPointTwo.position, refPointOne.position, curPercent);
        }
        else
        {
            transform.position = Vector3.Lerp(refPointOne.position, refPointTwo.position, curPercent);
        }

        curTime += Time.deltaTime;
        if(curTime >= timeToDest)
        {
            curTime = 0;
            isForward = !isForward;
        }

    }
}

//Vecotr3.Lerp???
