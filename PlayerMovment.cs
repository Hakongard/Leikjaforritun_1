using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // þetta ersvo hægt sé að breyta hraðanum bæði hér og í unity
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // þessir takka breyta hnitunum á playerinum með þvi að láta hann fara áfram, aftur eða snúa sér
        if (Input.GetKey(KeyCode.W))//áfram
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))//áfram
        {
            transform.position += -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -2, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 2, 0));
        }

    }
}
