using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOfAll : MonoBehaviour {
    public static int P1Global;
    public static int P2Global;
    public static int P3Global;
    public static int P4Global;
    private static ScoreOfAll instance = null;
    public static ScoreOfAll Instance;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
