using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinController : MonoBehaviour
{
    private Animator animat;
    private void Start()
    {
        animat = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.GetComponent<GameObject>().name);
        //if (other.GetComponent<GameObject>().name == "Ball")
        animat.SetTrigger("Collect");
    }
}
