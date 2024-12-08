using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public AudioClip successSound;
    public AudioSource audioSource;
    //public PlayerController playerController;
    public GameObject losePanel;
    public GameObject winPanel;
    public TextMeshProUGUI objectiveText;
    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        objectiveText.text = "KILL AN ENEMY";
    }

    public void UpdateScore(bool didHit)
    {
        if (didHit)
        {
            audioSource.PlayOneShot(successSound);
            objectiveText.text = "GO TO PLANET";
        }
        
    }
    public void EndGame(bool didWin)
    {
        if (didWin)
        {
            winPanel.SetActive(true);
        }
        else
        {
            losePanel.SetActive(true);
        }
        Time.timeScale = 0;
    }
}
