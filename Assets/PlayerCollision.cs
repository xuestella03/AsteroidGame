using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TargetPlanet"))
        {
            if (GameManager.Instance.ObjectiveChanged)
            {
                //Debug.Log("got to target, game should be done now");
                GameManager.Instance.EndGame(true);
            }
            else
            {
                GameManager.Instance.EndGame(false);
            }
            
        }
        if (other.CompareTag("Enemy") || other.CompareTag("EnemyMissile") || other.CompareTag("Asteroid"))
        {
            GameManager.Instance.EndGame(false);
        }
    }
}
