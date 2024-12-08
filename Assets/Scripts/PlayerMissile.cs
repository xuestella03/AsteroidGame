using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissile : MonoBehaviour
{
    public AudioClip successSound;
    public AudioSource audioSource;
    public float speed = 50f;
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
        //audioSource.PlayOneShot(successSound);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //audioSource.PlayOneShot(successSound);
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameManager.Instance.UpdateScore(true);
        }
        //if (other.CompareTag("MainCamera"))
        //{
        //    GameManager.Instance.EndGame(false);
        //    Destroy(gameObject);
 
        //}
    }
}
