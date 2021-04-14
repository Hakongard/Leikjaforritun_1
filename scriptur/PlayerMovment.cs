using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class PlayerMovment : MonoBehaviour
{

    public float speed = 0.5f;
    public float sideways = 0.5f;
    public float jump = 20;

    bool hopp;

    public static int count = 3;
    public Text countText;

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }
        if (Input.GetKey(KeyCode.Q))//snúa leikmanni
        {
            transform.Rotate(new Vector3(0, -5, 0));
        }
        if (Input.GetKey(KeyCode.W))//áfram
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))//til baka
        {
            transform.position += -transform.forward * speed;

        }
        if (Input.GetKey(KeyCode.D))//hægri
        {
            transform.position += transform.right * sideways;
        }
        if (Input.GetKey(KeyCode.A))//vinstri
        {
            //hreyfir player um sideways í hvert skipti sem ýtt er á leftArrow
            transform.position += -transform.right * sideways;
        }

        if (transform.position.y >=7)
        {
            hopp = false;
        }
        if (transform.position.y == 1)
        {
            hopp = true;
        }
        if (Input.GetKey(KeyCode.Space) && hopp==true)
        {
                //Debug.Log("búmm");
                //Vector3 movement = new Vector3(0, 10, 0);
                transform.position += transform.up * jump;
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "hlutur")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;
            Debug.Log("Nú er ég komin með " + count);
            SetCountText();//kallar á fallið
        }
        if (collision.collider.tag == "pikk")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 5;
            Debug.Log("Nú er ég komin með " + count);
            SetCountText();//kallar á fallið
        }
        if (collision.collider.tag == "hindrun")
        {
            collision.collider.gameObject.SetActive(false);
            count = count - 1;
            transform.position = new Vector3(100, 1, -15);
            Debug.Log("Nú er ég komin með " + count);
            SetCountText();//kallar á fallið
        }
    }
    void SetCountText()
    {
        countText.text = "Líf: " + count.ToString();

        if (count <= 0)
        {
            this.enabled = false;//kemur í veg fyrir að playerinn geti hreyfst áfram eftir dauðan
            countText.text = "Svo dauðððððððððððððððður " + count.ToString() + " stigum";

            StartCoroutine(Bida());

        }

    }
    IEnumerator Bida()
    {
        yield return new WaitForSeconds(1);
        Endurræsa();
    }
    public void Endurræsa()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Level_1
        SceneManager.LoadScene(0);
    }
}
