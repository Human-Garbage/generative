using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineToLine : MonoBehaviour
{
    public float width = .1f;
    // Start is called before the first frame update
    void Start()
    {
        DrawLines();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void DrawLines()
    {
        LineRenderer[] linePoints = FindObjectsOfType<LineRenderer>();
        for (int i = 0; i < linePoints.Length; i++)
        {

            linePoints[i].positionCount = linePoints.Length;
            for (int j = 0; j < linePoints[i].positionCount; j++)
            {
                linePoints[i].SetPosition(j, linePoints[j].transform.position);
            }



        }
    }
}
