using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhosReady2p : MonoBehaviour
{

    public static int NumberOfReady = 0;

    private void Awake()
    {
        NumberOfReady = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (NumberOfReady == 2)
        {
            SceneManager.LoadScene("Scene_test 2P");
        }
    }
}
