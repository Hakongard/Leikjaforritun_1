using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sigur : MonoBehaviour
{
    // maður fer á næstu sceenu ef maður snertir sigur triggerinn
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("sigur");
        SceneManager.LoadScene(2);
    }
}
