using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyUp : MonoBehaviour {
    public string Ready;
    public bool isReady;
    public void Awake()
    {
        isReady = false;
    }
    void Start () {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(Ready)&& isReady==false)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            isReady = !isReady;
            WhosReady.NumberOfReady++;
        }
    }
}
