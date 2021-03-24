using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float xValue = 1;
    [SerializeField] float yValue = 1;
    [SerializeField] float zValue = 1;
    void Update()
    {
        transform.Rotate(xValue,yValue,zValue);
    }
}
