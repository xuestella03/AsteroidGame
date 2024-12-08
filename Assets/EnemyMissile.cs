using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{

    public float speed = 20f;
    public float ttl = 300f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, ttl); // destroy missiles if they've been around for too long
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Enemy"))
        //{
        //    Destroy(other.gameObject);
        //    Destroy(gameObject);
        //}
        if (other.CompareTag("MainCamera"))
        {
            GameManager.Instance.EndGame(false);
            Destroy(gameObject);
 
        }
    }
}
