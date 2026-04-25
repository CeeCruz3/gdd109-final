using UnityEngine;
using System.Collections;

public class MoveFlip : MonoBehaviour
{
    public Vector3 pointB;
    public AnimationCurve curve;

    IEnumerator Start()
    {
        var pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 6.0f));
            
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 6.0f));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            float strength = curve.Evaluate(i);
            thisTransform.position = Vector3.Lerp(startPos, endPos, i*strength);
           
        }

        i = 0f;

        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            yield return null;
        }
        thisTransform.rotation *= Quaternion.Euler(0, 0, 180);
    }
}