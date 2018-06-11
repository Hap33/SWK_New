using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingOrNot : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Renderer>().enabled = false;
    }
}
