using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public float rotateSpeed = 2f;


    void Update()
    {
        transform.Rotate(0, rotateSpeed * 50 * Time.deltaTime * Time.timeScale, 0, Space.World);
    }
}
