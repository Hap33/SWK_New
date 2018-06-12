using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J2Camera : MonoBehaviour {
    public Camera Cam;
    void Update()
    {
        if (MultiHowMany.Singleton.PlayerNumber == 2)
        {
            Cam.rect = new Rect(0, 0, 1, 0.5f);
        }
        else
        {
            Cam.rect = new Rect(0, 0.5f, 1, 0.5f);
        }
    }
}
