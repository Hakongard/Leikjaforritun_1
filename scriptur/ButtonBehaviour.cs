using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    // Þetta lætur skipta um senu þegar klikað er á takkan
    public void Byrja()
    {
        Debug.Log("klikk");
        SceneManager.LoadScene(1);
    
    }
}
