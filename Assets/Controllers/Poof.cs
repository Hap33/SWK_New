using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poof : MonoBehaviour
{
    public float[] TpLocation = new float[2];
    // Use this for initialization
    void Awake()
    {
        WhereToGo();
    }
    void WhereToGo()
    {
        TpLocation[0] = Random.Range(-90f, 105);
        TpLocation[1] = Random.Range(-95f, 100);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ceiling")
        {
            WhereToGo();
            transform.position = new Vector3(TpLocation[0], 8, TpLocation[1]);
        }
    }
}
