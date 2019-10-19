using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMod : MonoBehaviour
{
    public GameObject hidePlane;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            hidePlane.SetActive(true);
        }
    }
}