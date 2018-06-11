using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour {

    // Use this for initialization
    public static void YupImDead()
    {
        DecisiveWin.P2Alive = false;
        DecisiveWin2p.P2Alive = false;
        DecisiveWin3p.P2Alive = false;
    }
}
