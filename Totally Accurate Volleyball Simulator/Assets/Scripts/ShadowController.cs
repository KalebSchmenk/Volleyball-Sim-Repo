using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowController : MonoBehaviour
{

    public GameObject player;

    public bool isPlayer1;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = transform.position;

        if (isPlayer1)
        {
            pos.x = player.transform.position.x + 0.25f;
            pos.y = player.transform.position.y - 1.25f;
        }
        else
        {
            pos.x = player.transform.position.x - 0.25f;
            pos.y = player.transform.position.y - 1.25f;
        }
        

        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (isPlayer1)
        {
            pos.x = player.transform.position.x + 0.25f;
        }
        else
        {
            pos.x = player.transform.position.x - 0.25f;
        }

        transform.position = pos;

    }
}
