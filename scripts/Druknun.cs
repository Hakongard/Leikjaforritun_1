using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Druknun : MonoBehaviour
{
    // þessi scripta lætur leikinn enduræsast ef maður dettur úti vatnið en maður heldur samt stigunum
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Bida());
        Debug.Log("drukknun");
    }
    IEnumerator Bida()
    {
        yield return new WaitForSeconds(3);
        Endurræsa();
    }
    public void Endurræsa()
    {
        SceneManager.LoadScene(1);
    }

}
