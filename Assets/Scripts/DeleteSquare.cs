using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSquare : MonoBehaviour
{
    GameObject square2;
    public float duration = 2f;
    float t = 0f;

    private void Start()
    {
        square2 = GameObject.Find("Square2");

    }

    private void Update()
    {


        t += Time.deltaTime;

        if (t > 4)
        {
            Destroy(square2);
        }

    }
}
