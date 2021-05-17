using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagezone2 : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController2 controller = other.GetComponent<RubyController2>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
