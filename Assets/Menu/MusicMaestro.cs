using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMaestro : MonoBehaviour {
    public AudioClip musicMan;
    public AudioSource letsDance;
    // Use this for initialization
    void Start () {
        letsDance.PlayOneShot(musicMan);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
