using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpin : MonoBehaviour
{

    Vector3 spin;
  
    void Update()
    {
        spin = new Vector3(5f, 5f, 0f);
        transform.Rotate(spin);
    }
}
