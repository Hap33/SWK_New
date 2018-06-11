using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMenu : MonoBehaviour {

    public AudioSource FromThis;
    public AudioClip SingThis;
    private static MusicMenu instance = null;
    public static MusicMenu Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        FromThis.PlayOneShot(SingThis);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Scene_test"|| SceneManager.GetActiveScene().name == "Scene_test 3p"|| SceneManager.GetActiveScene().name =="Scene_Test 2p")
        {
            Destroy(this.gameObject);
        }
    }
}
