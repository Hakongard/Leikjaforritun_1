using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naesta_bord : MonoBehaviour
{
    // þegar það er rekist í hlutin þa skiptir í scenuna sem er einu númeri hærra
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
