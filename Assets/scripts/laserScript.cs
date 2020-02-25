using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    public Transform a, b;
    LineRenderer laserLine;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        laserLine.SetWidth(.2f, .2f);
    }

    // Update is called once per frame
    void Update()
    {
        b.position = a.position - new Vector3(0,7,0);
        laserLine.SetPosition(0, a.position);
        laserLine.SetPosition(1, b.position);
    }
}
