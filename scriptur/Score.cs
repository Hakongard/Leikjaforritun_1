using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // þetta sínir lokastigin þegar maður klárar leikinn
    public Text myText;
    void Start()
    {
        myText.text = "Líf: " + PlayerMovment.count.ToString();
    }
}
