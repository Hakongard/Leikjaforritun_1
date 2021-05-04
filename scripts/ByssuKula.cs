using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ByssuKula : MonoBehaviour
{
    
    public GameObject sprengjan;
    public static int damage;//klasabreyta


    private void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.tag == "kassi")
        {
            damage += 10;
            Destroy(collision.gameObject);//eyðir kassanum
            Destroy(gameObject);//eyða kúlunni þarf ekki eyðist eftir 0.5 sek                 
            Sprengja();//framkvæmir sprengju
            Debug.Log(damage.ToString());
        }
        if (collision.collider.tag == "ovinur")
        {
            Debug.Log("hitt");
            damage += 10;
            Destroy(collision.gameObject);//eyðir kassanum
            Destroy(gameObject);//eyða kúlunni þarf ekki eyðist eftir 0.5 sek                 
            Sprengja();//framkvæmir sprengju
            Debug.Log(damage.ToString());
        }

    }
    void Sprengja()
    {
        Instantiate(sprengjan, transform.position, transform.rotation);
    }
}
