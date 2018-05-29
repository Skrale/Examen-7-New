using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpManager : MonoBehaviour
{
    public Transform startMarker;
    public GameObject prefab;

    public Transform[] endMarkers;

    public bool canLerp = false;

    public IEnumerator MoveObject(GameObject tempObject, Vector3 startPos, Vector3 endPos, float time)
    {
        float elapsedTime = 0;
        tempObject.transform.position = startPos;

        while (elapsedTime < time)
        {
            tempObject.transform.position = Vector3.Lerp(tempObject.transform.position, endPos, (elapsedTime / time));

            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        tempObject.transform.position = endPos;
    }

    /*
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker1.position);
    }

    void Update()
    {
        if (canLerp)
        {
            Debug.Log("ongo");
            DoLerp();
        }
    }
    
    public void DoLerp()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        lerpDit.transform.position = Vector3.Lerp(startMarker.position, endMarker1.position, fracJourney);
    }*/
}
