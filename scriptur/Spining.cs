using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spining : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // þetta lætur hlutinn snúa endalaust
        transform.Rotate(new Vector3(0, 1, 0));
    }
}
