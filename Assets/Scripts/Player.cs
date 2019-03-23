using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    bool IsplayerMove = true;
    public GameObject PuseMenu;
    public string PlayerState;
    //public GameObject MyPlayer;
    public float speed = 0;
    public float MaxSpeed = 60;

    public float increaseamount = 3;
    public float timer = 0;
    public float acceleration = 1;
    public float CoinsCounter = 0;
    public int myScore = 0;
    public Text ScoreText;
    public float duration = 1;
    public int newHighScore;
    public Text mycoins;
    public Text scoreGameover;
    public Text currentscoreGameover;
    public Text Name;
    AudioSource audioSource;
    public AudioClip walk;
    private void Awake()
    {
        if (PlayerController.Instance.MyPlayer == null)
            PlayerController.Instance.MyPlayer = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetString("sound"));
        audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.GetString("sound") == "yes")
        {
            audioSource.Play();
        }
        else if (PlayerPrefs.GetString("sound") == "no")
        {
            audioSource.Stop();
        }
        ScoreText.text = "0";
        ScoreText.color = Color.blue;
        mycoins.text = "0";
        mycoins.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= duration)
        {
            myScore += 5;
            timer = 0;
            ScoreText.text = ("" + myScore);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Block")
        {
            Name.text = "Name: " + PlayerPrefs.GetString("savedName");
            currentscoreGameover.text = "Your  Score  " + myScore.ToString();
            if (PlayerPrefs.GetInt("highscore") < myScore)
            {
                PlayerPrefs.SetInt("highscore", myScore);
                scoreGameover.text = "Your  Score  " + myScore.ToString();
            }
            else
            {
                scoreGameover.text = "Highest Score  " + PlayerPrefs.GetInt("highscore").ToString();
            }
            IsplayerMove = false;
            PuseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coins")
        {
            Destroy(other.gameObject);
            CoinsCounter++;
            mycoins.text = "" + CoinsCounter;
        }
    }

    public void shopmenu()
    {
        Time.timeScale = 0;
    }
    public void shopcoins()
    {
        if (CoinsCounter>=100)
        {
            CoinsCounter -= 100;
            myScore += 100;
            ScoreText.text = ("" + myScore);
            mycoins.text = "" + CoinsCounter;
        }
        Time.timeScale = 1;
    }


}