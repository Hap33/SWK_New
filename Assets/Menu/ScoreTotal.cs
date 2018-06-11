using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTotal : MonoBehaviour {
    private int Scoooooooore1 = 0;
    private int Scoooooooore2 = 0;
    private int Scoooooooore3 = 0;
    private int Scoooooooore4 = 0;
    public Button Pl1;
    public Button Pl2;
    public Button Pl3;
    public Button Pl4;
    void Awake()
    {
        Pl1.GetComponentInChildren<Text>().text = "Joueur 1 : " + ScoreOfAll.P1Global;
        Pl2.GetComponentInChildren<Text>().text = "Joueur 2 : " + ScoreOfAll.P2Global;
        Pl3.GetComponentInChildren<Text>().text = "Joueur 3 : " + ScoreOfAll.P3Global;
        Pl4.GetComponentInChildren<Text>().text = "Joueur 4 : " + ScoreOfAll.P4Global;
    }
}
