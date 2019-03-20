using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour
{
    public float speed = 3;
    public float MaxSpeed = 60;
    public GameObject player;
    public float increaseamount = 3;
    public float timer = 0;
    public float acceleration = 30;
    public float CoinsCounter = 0;
    public float myScore = 0;
    public Text ScoreText;
    public float duration = 1;
    public int newHighScore;
    public Text mycoins;
    public Image coinImage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        if (speed < MaxSpeed)
        {
            speed = Mathf.SmoothStep(speed, MaxSpeed, timer / increaseamount);
            timer += Time.deltaTime;
            speed++;

        }

        timer += Time.deltaTime;

        if(timer >= duration)
        {
            myScore += 5;
            timer = 0;
            ScoreText.text = ("" + myScore);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "coin")
        {
            CoinsCounter++;
            Destroy(other.gameObject);
            mycoins.text = "" + CoinsCounter;
           // print(CoinsCounter);

        }
    }

   public void StoreHighScore(int newHighScore)
    {
        print("myscore");
        myScore = PlayerPrefs.GetInt("Highscore", 0);
        if (newHighScore > myScore)
            PlayerPrefs.SetInt("highscore", newHighScore);
    }

}
