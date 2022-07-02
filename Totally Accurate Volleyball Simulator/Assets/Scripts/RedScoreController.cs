using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class RedScoreController : MonoBehaviour
{

    public TMP_Text redScore;

    public GameObject Volleyball;

    public GameObject BlueBallSpawn;

    public int redScoreNumber = 0;

    public Rigidbody2D rb;

    private int MaxVelocity = 1;

    // Start is called before the first frame update
    void Start()
    {
        redScore.text = "" + redScoreNumber;
    }

    // Update is called once per frame
    void Update()
    {
        redScore.text = "" + redScoreNumber;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Volleyball")
        {
            redScoreNumber += 1;
            Volleyball.transform.position = BlueBallSpawn.transform.position;
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxVelocity);
        }
    }
}
