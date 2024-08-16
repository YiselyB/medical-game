using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class services : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void exitGame()//Exits the application
    {
        Application.Quit();
    }
}
