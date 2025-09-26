using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class menusstart : MonoBehaviour
{
  public void switchscenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void leave_application()
    {
        Application.Quit();
    }
}
