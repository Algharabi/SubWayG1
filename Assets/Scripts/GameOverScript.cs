using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{

    public Button Replay;
    public Canvas gameCanvas;
    bool isGameStarted = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isGameStarted)
        //{
        //    gameCanvas.SetTrigger("Hide");
        //
    }
    public void OnClickButton()
    {
       
        SceneManager.LoadScene("PlayerScene");
        Time.timeScale = 1;
    }

    public void OnClickButtonMain()
    {

        SceneManager.LoadScene("MainMenue");
        Time.timeScale = 1;
    }



    public void Quitbtn()
    {
        Application.Quit();
    }





}
