using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUse : MonoBehaviour
{
    public string sname = "lv1";

    public void changeScene()
    {
        SceneManager.LoadScene(sname);
    }

    public void quitScene()
    {
        Application.Quit();
    }
}
