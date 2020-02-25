using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{
    public GameObject phisicalthings;
    [Range(-6, 6)]
    private float i = 0;
    private float smooth = 2.0f;
    private int x = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.ToString() == "Wooden_Barrel(Clone)" && x <60)
        {
            x++;
            //Debug.Log(x);

            foreach (ContactPoint contact in collision.contacts)
            {
                // Debug.Log(phisicalthings.transform.rotation);
                if (collision.gameObject.name.ToString() == "Wooden_Barrel(Clone)")
                {
                    i = collision.gameObject.transform.position.x > -0.5f ? -6f : 6;
                    Quaternion target = Quaternion.Euler(0, 0, i);

                    phisicalthings.transform.rotation = Quaternion.Slerp(phisicalthings.transform.rotation, target, Time.deltaTime * smooth);
                }
            }
            
        return;
        }
       
    }
}

