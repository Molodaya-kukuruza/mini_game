using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBut : MonoBehaviour
{
    private GameObject levelPans;
    private void Start()
    {
        levelPans = GameObject.Find("Panel_levels");
        levelPans.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnPress()
    {
        GameObject pausePan;
        pausePan = GameObject.Find("Panel_pause");
        pausePan.SetActive(false);
        //GameObject obj = child.GetComponent<GameObject>();
        //Debug.Log(child.name
        Debug.Log(levelPans);
        levelPans.SetActive(true);
    }
}
