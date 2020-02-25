using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FallingForms : MonoBehaviour
{
    private List<GameObject> formThatCollisionInSwings = new List<GameObject>();

    public TextMeshProUGUI points;
    public TextMeshProUGUI life;
    public GameObject gameOver, veryNice, nextLevel, beck;

    private int lifeNumber = 4;
    private int pointNumber = 0;
    public int PointNumber
    {
        get { return pointNumber; }
        set { pointNumber = value >= 0 && value <= 100 ? value : 100; }
    } 
    private bool Pause;

    void OnCollisionEnter(Collision collision)
    {  // check if formGamm tuoched in Swings and if more then 4 touched - destry this after 3 second
        foreach (ContactPoint contact in collision.contacts)
        {
 //           Debug.Log(collision.gameObject.name.ToString() == "Wooden_Barrel(Clone)");
            if (collision.gameObject.name.ToString() == "Wooden_Barrel(Clone)")
            {
                formThatCollisionInSwings.Add(collision.gameObject);
          //      Debug.Log("when entered: " + formThatCollisionInSwings.Count);
                break;
            }
            if (collision.gameObject.name.ToString() == "Plane")
            {
 //               Debug.Log("sine");
                chengeLife();
                break;
            }
        }

        if (formThatCollisionInSwings.Count == 6)
        {
            veryNice.SetActive(true);   
            Invoke("destroy", 1) ;
        }
    }

    void OnCollisionExit(Collision other)
    {  
        if (other.gameObject.name.ToString() == "Wooden_Barrel(Clone)")
        {
            formThatCollisionInSwings.Remove(other.gameObject);
           //Destroy(other.gameObject);

           // Debug.Log("when exit: "  + formThatCollisionInSwings.Count);
            return;
        }      
    }

    private void destroy()
    {
        pointNumber += 10;
        PointNumber = pointNumber;
        life.text = (++lifeNumber).ToString();
        points.text = PointNumber.ToString() + "/100";

        veryNice.SetActive(false);  
        for (int i = 0; i < formThatCollisionInSwings.Count; i++)
        {
            Destroy(formThatCollisionInSwings[i]);
        }
        formThatCollisionInSwings.Clear();

        if (PointNumber >= 100)
        {
            nextLevel.SetActive(true);
            Invoke("loadScene", 3);
        }
    }

    public void loadScene()
    {
        nextLevel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void chengeLife()
    {
        life.text = (--lifeNumber).ToString();

        if ((Convert.ToInt32(life.text) <= 0))
        {
            veryNice.SetActive(false);
            gameOver.SetActive(true);
            beck.SetActive(true);

            Time.timeScale = 0;
        }
    }
}
