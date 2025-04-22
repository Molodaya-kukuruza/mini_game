using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLvl : MonoBehaviour
{
    public void OnPress1()
    {
        SceneManager.LoadScene(1);
    }

    public void OnPress2()
    {
        SceneManager.LoadScene(2);
    }

    public void onPress3()
    {
        SceneManager.LoadScene(3);
    }

    public void onPressEx()
    {
        SceneManager.LoadScene(0);
    }
}
