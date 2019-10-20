using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
  public void GoToDemo()
    {
        SceneManager.LoadScene("DemoScene");
    }
    public void GoToTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void GoToIntro()
    {
        SceneManager.LoadScene("Intro");
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
