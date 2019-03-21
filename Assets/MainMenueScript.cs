using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenueScript : MonoBehaviour
{
    public Button play;
    public Dropdown Settings;
    AudioSource audioSource;
    public AudioClip walk;
    public InputField Name;
    public Text message;
    public static MainMenueScript Instance;
    // Start is called before the first frame update
    void Start()
    {
      
        audioSource = GetComponent<AudioSource>();
        List<string> showList = new List<string>() { "Sound Setting", "Sound Off", "Sound On" };
      //  showList.
        Settings.AddOptions(showList);
 }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButton()
    {
        
        if (Name.text == "")
        {
            message.text = "Plase Enter Your Name";
        }
        else
        {
            PlayerPrefs.SetString("savedName", Name.text.ToString());
            SceneManager.LoadScene("PlayerScene");
        }


    }

    public int SettingList()
    {
        int a = 0;
        if (Settings.value == 1)
        {
            audioSource.clip = walk;
            audioSource.Stop();
            return a = 1;
        }
        else if (Settings.value == 2)
        {
            audioSource.clip = walk;
            audioSource.Play();
            return a = 2;
        }
        return a;
    }
}
