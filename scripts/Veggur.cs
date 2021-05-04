using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veggur : MonoBehaviour
{
    public GameObject veggur;
    // Lætur veggin bara fara ef maður er með 100 stig og snertir triggerinn
    private void OnTriggerEnter(Collider other)
    {
        if(Money.count >= 100)
        { 
            veggur.SetActive(false);
            Debug.Log("veggur");
        }
    }
}
