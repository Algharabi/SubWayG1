using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour
{
    public float speed = 0;
    public float MaxSpeed = 60;
   
    public float increaseamount = 3;
    public float timer = 0;
    public float acceleration = 1;
    public float CoinsCounter = 0;
    public float myScore = 0;
    public Text ScoreText;
    public float duration = 1;
    public int newHighScore;
    public Text mycoins;
    public Image coinImage;
   // public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * speed);

        speed += acceleration;

        if (speed > MaxSpeed)
            speed = MaxSpeed;
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.position += transform.forward * speed * Time.deltaTime;
        //if (speed < MaxSpeed)
        //{
        //   speed = Mathf.SmoothStep(speed, MaxSpeed, timer / increaseamount);
        //    timer += Time.deltaTime;
        //    speed++;

        //}

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
           
            Destroy(other.gameObject);
            CoinsCounter++;
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
