using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundSwings : MonoBehaviour
{
    public Transform tr;

    private void Start()
    {
        tr = transform;
    }
    void Update()
    {
        tr.RotateAround(transform.position, Vector3.up, 10 * Time.deltaTime);
    }
}
