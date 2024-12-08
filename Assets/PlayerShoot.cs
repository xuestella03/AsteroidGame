using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject missile;
    public AudioClip shootSound;
    public AudioSource audioSource;
    //public Transform spawn;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        //if (Input.GetAxis("Thrust"))
        {
            //Vector3 spawn = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4);
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(missile, Camera.main.transform.position, Camera.main.transform.rotation);
        missile.transform.LookAt(Camera.main.transform.forward);
        audioSource.PlayOneShot(shootSound);
        //Debug.Log("Player Shoot");
    }
}
