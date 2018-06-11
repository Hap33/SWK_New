using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour {

	// Use this for initialization
    public static void YupImDead()
    {
        DecisiveWin.P1Alive = false;
        DecisiveWin3p.P1Alive = false;
        DecisiveWin2p.P1Alive = false;
    }
}
