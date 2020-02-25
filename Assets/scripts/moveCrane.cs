using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class moveCrane : MonoBehaviour
{
    public trowForm tf;
    public float speed = 10.0f;

    private string sceneName;
    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        sceneName = currentScene.name;
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        //move rihght and laft

        float translationX = Input.GetAxis("Horizontal") * speed;
        float translationY = Input.GetAxis("Vertical") * speed;
        translationX *= Time.deltaTime;
        translationY *= Time.deltaTime;



        if (sceneName == "first")
        {
            transform.Translate(translationX, 0, 0);
        }
        else if (sceneName == "level 2")
        {
            transform.Translate(translationX, translationY, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.throwForm_();
        }
    }
}
