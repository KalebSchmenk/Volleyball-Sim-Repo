using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameTimer : MonoBehaviour
{

    float time = 5;

    public TMP_Text timer;

    public GameObject Volleyball;

    public GameObject Player1;

    public GameObject Player2;

    public GameObject blueWin;

    public GameObject redWin;

    public GameObject tieGame;

    public RedScoreController redTeam;

    public BlueScoreController blueTeam;

    private bool timerOff = false;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = "Time left   " + time;

        blueWin.SetActive(false);
        redWin.SetActive(false);
        tieGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("GameScene");
        }

        if (!timerOff)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                EndGame();
            }
            timer.text = "Time left   " + time.ToString("0");
        }
    }

    void EndGame()
    {
        int bluescore = blueTeam.blueScoreNumber;
        int redscore = redTeam.redScoreNumber;

        if (bluescore > redscore)
        {
            blueWin.SetActive(true);
        }
        else if (redscore > bluescore)
        {
            redWin.SetActive(true);
        }
        else
        {
            tieGame.SetActive(true);
        }

        Destroy(Player1);
        Destroy(Player2);
        Destroy(Volleyball);

        timerOff = true;
    }
}
