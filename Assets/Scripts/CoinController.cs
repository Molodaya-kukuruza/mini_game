using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Animator animat;

    private void Start()
    {
        animat = GetComponent < Animator >();
    }

    private void OnTriggerEnter(Collider other)
    {
        animat.SetTrigger("Collect");
    }
}
