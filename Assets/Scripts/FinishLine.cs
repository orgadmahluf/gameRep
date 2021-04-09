using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject panel;

    private void OnCollisionEnter(Collision collision)
    {
        print("hello");
        panel.SetActive(true);
    }
    
}
