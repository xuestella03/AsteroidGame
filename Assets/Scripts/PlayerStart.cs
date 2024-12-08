using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    public Transform planetB;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(planetB.position);
    }

    
}
