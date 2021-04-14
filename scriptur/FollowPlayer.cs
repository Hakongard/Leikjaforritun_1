using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Bý til gameobject sem myndavélin á að elta
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void Update()
    {
        // þetta myndavélina elta objectið sem er valið
        transform.position = player.transform.position + offset;
    }
}
