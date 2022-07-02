using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class BlueScoreController : MonoBehaviour
{

    public TMP_Text blueScore;

    public GameObject Volleyball;

    public GameObject RedBallSpawn;

    public int blueScoreNumber = 0;

    public Rigidbody2D rb;

    private int MaxVelocity = 1;

    // Start is called before the first frame update
    void Start()
    {
        blueScore.text = "" + blueScoreNumber;
    }

    // Update is called once per frame
    void Update()
    {
        blueScore.text = "" + blueScoreNumber;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Volleyball")
        {
            blueScoreNumber += 1;
            Volleyball.transform.position = RedBallSpawn.transform.position;
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxVelocity);
        }
    }
}
