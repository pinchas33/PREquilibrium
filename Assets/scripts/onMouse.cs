using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onMouse : MonoBehaviour
{
    public Button button;
    public bool flag;
    public trowForm trF;


    //public void OnMouseEnter()
    //{
    //    Debug.Log("enter");
    //}
    public void OnMouseEnter() 
    {
        flag = true;
        trF.throwForm_();
        Debug.Log("exit");
    }
    public void OnMouseDown()
    {
        flag = false;
        Debug.Log("down");
    }
}
