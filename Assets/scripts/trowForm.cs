using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class trowForm : MonoBehaviour
{
    public GameObject form, crane, puuseText, beck;
    public void throwForm_()
    {
        Instantiate(form, crane.transform.position - new Vector3(0, 1, 0), transform.rotation);//Quaternion.identity);
    }
    public void moveRight()
    {
        crane.transform.position += Vector3.right * .2f;
    }
    public void moveLeft()
    {
        crane.transform.position += Vector3.left * .2f;
    }

    public void Pause()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            puuseText.SetActive(false);
            beck.SetActive(false);

        }
        else if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            puuseText.SetActive(true);
            beck.SetActive(true);
        }
    }
    public void run()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
