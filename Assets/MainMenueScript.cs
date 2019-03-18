using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenueScript : MonoBehaviour
{
  public  Button play;
   public Dropdown Settings;
    // Start is called before the first frame update
    void Start()
    {
        SettingList();


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnClickButton()
    {
        SceneManager.LoadScene("Playing");
    }

    void SettingList()
    {
        List<string> showList = new List<string>() { "Sound Off", "Sound On" };
        Settings.AddOptions(showList);
    }
}
