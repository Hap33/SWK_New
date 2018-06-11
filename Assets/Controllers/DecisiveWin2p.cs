using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecisiveWin2p : MonoBehaviour
{
    public static bool P1Alive = true;
    public static bool P2Alive = true;

    void Update()
    {
        CheckForWinner();
    }
    void CheckForWinner()
    {
        if (P1Alive == true && P2Alive == false )
        {
            SceneManager.LoadScene("ReadyUp_2p");
        }
        else
        {
            if (P1Alive == false && P2Alive == true)
            {
                SceneManager.LoadScene("ReadyUp_2p");
            }
        }
    }
}
