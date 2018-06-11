using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodbyeSword : MonoBehaviour {

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "sword kinda")
        {
            Debug.Log("GoodbyeSword");
        }
    }

}
