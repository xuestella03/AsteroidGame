using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyShoot : MonoBehaviour
{
    public GameObject missilePrefab;
    //public Transform spawn;
    //public Transform player;

    public float fireRate = 2f;
    private float nextFire = 0f;
    private Vector3 spawn;

    // Update is called once per frame
    void Update()
    {
           
        spawn = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4);

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }
    void Shoot()
    {
        
        GameObject missile = Instantiate(missilePrefab, spawn, Quaternion.identity);
        missile.transform.LookAt(Camera.main.transform.position);
        //Debug.Log("Shoot");
    }
}
