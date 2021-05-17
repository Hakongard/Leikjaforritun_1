using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthcollectble2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController2 controller = other.GetComponent<RubyController2>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
