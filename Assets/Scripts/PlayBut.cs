using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBut : MonoBehaviour
{

    private GameObject levelPan;
    private void Start()
    { 
        levelPan = GameObject.Find("Panel_levels");
        levelPan.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnPress()
    {
        GameObject playPan;
        playPan = GameObject.Find("Panel_play");
        playPan.SetActive(false);
        //GameObject obj = child.GetComponent<GameObject>();
        //Debug.Log(child.name
        Debug.Log(levelPan);
        levelPan.SetActive(true);
    }

}
