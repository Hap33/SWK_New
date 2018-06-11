using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecisiveWin3p : MonoBehaviour {
    public static bool P1Alive = true;
    public static bool P2Alive = true;
    public static bool P3Alive = true;

    void Update()
    {
        CheckForWinner();
    }
    void CheckForWinner()
    {
        if (P1Alive == true && P2Alive == false && P3Alive == false )
        {
            SceneManager.LoadScene("ReadyUp_3p");
        }
        if (P2Alive == true && P1Alive == false && P3Alive == false )
        {
            SceneManager.LoadScene("ReadyUp_3p");
        }
        if (P3Alive == true && P2Alive == false && P1Alive == false)
        {
            SceneManager.LoadScene("ReadyUp_3p");
        }
    }
}
