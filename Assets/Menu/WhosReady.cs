using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhosReady : MonoBehaviour {
    public static int NumberOfReady = 0;

    private void Awake()
    {
        NumberOfReady = 0;
    }
    void Update () {
		if (NumberOfReady == 4)
        {
            SceneManager.LoadScene("Scene_test");
        }
	}
}
