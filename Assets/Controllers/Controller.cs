using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float[] TpLocation= new float[2];
    private float RandomSound;
    public bool touched = false;
    public AudioClip dieLikeAGoat;
    public AudioClip boing1;
    public AudioClip boing2;
    public AudioClip boing3;
    public AudioClip boing4;
    public AudioClip boing5;
    public AudioClip boing6;
    public AudioClip splash;
    public AudioSource deathSound;
    public string
        moveHorizontal, moveVertical, cameraHorizontal, jumpAround;
    public bool isAlive = true;
    bool Jump = false;
    public void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Physics.gravity * GetComponent<Rigidbody>().mass * 10);
    }
    public void Gravity()
    {
        Physics.gravity = new Vector3(0, -1.5F, 0);
    }
    private void Awake()
    {
        deathSound = GetComponent<AudioSource>();
        WhereToGo();
    }
    void WhereToGo()
    {
       
        TpLocation[0] = Random.Range(-90f, 105);
        TpLocation[1] = Random.Range(-95f, 100);
    }
    void Start()
    {
        Gravity();
    }
    void Update()
    {
        if (isAlive == true)
        {
            var x = Input.GetAxis(moveHorizontal) * Time.deltaTime * 8.0f;
            var z = Input.GetAxis(moveVertical) * Time.deltaTime * 8.0f;
            var g = Input.GetAxis(cameraHorizontal) * Time.deltaTime * 300.0f;
            transform.Translate(0, 0, z);
            transform.Translate(-x, 0, 0);
            transform.Rotate(0, -g, 0);
            if (Input.GetButtonDown(jumpAround) && Jump == false)
            {
                GetComponent<Rigidbody>().velocity = Vector3.up * 5;
                Jump = true;
                WhatToSay();
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Jump = false;
        }
        if (col.gameObject.tag == "Ceiling")
        {
            AboveWater();
        }
        if (col.gameObject.name == "sword kinda"&& touched == false && col.gameObject.tag != gameObject.tag|| col.gameObject.tag == "Water")
        {
            transform.position = new Vector3(TpLocation[0], 9, TpLocation[1]);
            if (col.gameObject.tag == "Water")
            {
                deathSound.PlayOneShot(splash);
            }
            /*if (col.gameObject.name == "sword kinda")
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }*/
            deathSound.PlayOneShot(dieLikeAGoat);
            WhereToGo();

            /*isAlive = false;
            WhoAmI();
            if (col.gameObject.tag == "Water")
            {
                deathSound.PlayOneShot(splash);
            }
            transform.GetChild(0).gameObject.SetActive(false);
            if (col.gameObject.name == "sword kinda")
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
            transform.DetachChildren();
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            deathSound.PlayOneShot(dieLikeAGoat);
            touched = true;
            GetComponent<Collider>().isTrigger = true;*/

        }
    }
    void AboveWater() {
        WhereToGo();
        transform.position = new Vector3(TpLocation[0], 9, TpLocation[1]);
    }
    
    void WhatToSay()
    {
        RandomSound = Random.Range(0, 60);
        if (RandomSound <= 10)
        {
            deathSound.PlayOneShot(boing1);
        }
        if (RandomSound > 10 && RandomSound <= 20)
        {
            deathSound.PlayOneShot(boing2);
        }
        if (RandomSound > 20 && RandomSound <= 30)
        {
            deathSound.PlayOneShot(boing3);
        }
        if (RandomSound > 30 && RandomSound <= 40)
        {
            deathSound.PlayOneShot(boing4);
        }
        if (RandomSound > 40 && RandomSound <= 50)
        {
            deathSound.PlayOneShot(boing5);
        }
        if (RandomSound > 50)
        {
            deathSound.PlayOneShot(boing6);
        }
    }
}
