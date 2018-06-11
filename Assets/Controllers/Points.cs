using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {
    public int JoueurIndex;
    public Button ScoreButton;
    public AudioSource FromHere;
    public AudioClip SayThis;
    public int Score;
    public string ShownScore;
    public float timeLeft = 3.0f;
    public GameObject Explosion;
    public Transform PositionOfBoom;
    void Start()
    {
        Score = 0;
        ShownScore = ("Score = 0");
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != gameObject.tag && col.gameObject.tag != "epee" && col.gameObject.name != "sword kinda"&& col.gameObject.tag != "Ground")
        {
            Score += 1;
            ShownScore = Score.ToString();
            Instantiate(Explosion, PositionOfBoom.position, PositionOfBoom.rotation);
            FromHere.PlayOneShot(SayThis);
            ScoreButton.GetComponentInChildren<Text>().text = "Score = " + ShownScore;
            WhoAgain();
        }
    }

    void WhoAgain()
    {
        Pause.s_Singleton.AddScore(JoueurIndex);
        if (gameObject.tag == "P1")
        {
            Pause.P1Score += 1;
        }
        if (gameObject.tag == "P2")
        {
            Pause.P2Score += 1;
        }
        if (gameObject.tag == "P3")
        {
            Pause.P3Score += 1;
        }
        if (gameObject.tag == "P4")
        {
            Pause.P4Score += 1;
        }
    }
}
