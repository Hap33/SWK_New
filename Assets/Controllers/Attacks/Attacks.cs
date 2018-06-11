using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour {
    public AudioClip gotAKnight;
    public AudioSource fromThere;
    public GameObject Object;
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }
    public WakeUp epee;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("epee") && epee.IsActive == false)
        {
            fromThere.PlayOneShot(gotAKnight);
            other.transform.position = new Vector3(Random.Range(-50f, 50), Random.Range(8, 10), Random.Range(-50f, 50));
            Instantiate(Object, gameObject.transform.position, gameObject.transform.rotation);
            epee.Activate();
        }
    }
}
