using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    public AudioSource FromHere;
    public AudioClip Attack;
    public bool buttonPressed = false;
    public bool IsActive = false;
    public float timeLeft = 5.0f;
    public string ToThrow;
    void Update() {
        if (Input.GetButtonDown(ToThrow))
        {
            buttonPressed = true;
            FromHere.PlayOneShot(Attack);
        }
        if (buttonPressed == true)
        {
            Attaque();
        }
	}
    public void Activate()
    {
        gameObject.SetActive(true);
        IsActive = true;
    }
    public void Attaque()
    {
        transform.Rotate(0, 10f, 0);
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            buttonPressed = false;
            IsActive = false;
            gameObject.SetActive(false);
            timeLeft = 5.0f;
        }
    }
   
}
