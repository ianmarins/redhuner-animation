using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    List<GameObject> chao;
    List<Vector3> beginPosition;
    List<Vector3> endPostion;

    int count;

    public float timeStartedLerping;
    public float lerpTime;

    private void startLerping()
    {
        timeStartedLerping = Time.time;
    }

    void Start()
    {
        chao = new List<GameObject>();
        chao.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));

        beginPosition = new List<Vector3>();
        beginPosition.Add(new Vector3(0, 0, 0));

        endPostion = new List<Vector3>();
        endPostion.Add(new Vector3(0, 0, 30));

        count = 0;

        startLerping();
    }

    // Update is called once per frame
    void Update()
    {
        chao[0].transform.position = Lerp(beginPosition[0], endPostion[0], timeStartedLerping, 30);

    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;

        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
}
