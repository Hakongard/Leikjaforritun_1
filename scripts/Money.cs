using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money : MonoBehaviour
{
    public Text stig;
    public Text lifText;
    public static int count;
    public static int lif = 3;
    private static int damcount;

    // Start is called before the first frame update
    void Start()
    {
        stig.text = "Stig: " + count.ToString();
        lifText.text = "Líf: " + lif.ToString();
        damcount = ByssuKula.damage;
    }

    // Update is called once per frame
    void Update()
    {

        if (damcount != ByssuKula.damage)
        {
            count = count + 10;
            damcount = ByssuKula.damage;
            SetCountText();
        }

        // leikurinn restartar ef maður fer útaf eða missir öll lífinn maður
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene(1);
            count = 0;
        }
        if (lif <= 0)
        {
            SceneManager.LoadScene(1);
            lif = 3;
            count = 0;
        }
    }

    // ef þetta rekst á hluti með áhveðana hluti
    void OnCollisionEnter(Collision collision)
    {
        // ef player keyrir á object sem heitir hlutur
        if (collision.collider.tag == "money")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;
            Debug.Log("Nú er ég komin með " + count);
            SetCountText();//kallar á fallið
        }
        if (collision.collider.tag == "ovinur")
        {
            collision.collider.gameObject.SetActive(false);
            lif -= 1;
            SetlifText();
            
        }
    }

    // þessar eru kallaðar á þegar þarf að uppfæra texta
    void SetCountText()
    {
        stig.text = "Stig: " + count.ToString();
    }
    void SetlifText()
    {
        lifText.text = "Líf: " + lif.ToString();
    }
}
