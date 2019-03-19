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
    public Text requiredName;

    // Start is called before the first frame update
    void Start()
    {
      
        audioSource = GetComponent<AudioSource>();
        List<string> showList = new List<string>() { "Sound Setting", "Sound Off", "Sound On" };
        Settings.AddOptions(showList);


        PlayerPrefs.SetString("savedName",Name.ToString());
        PlayerPrefs.GetString("savedName",Name.ToString());


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButton()
    {
        if (Name.text == "")
        {
            requiredName.text = "Plase Enter Your Name";
        }
        else
        {
            SceneManager.LoadScene("Playing");
        }


    }

    public void SettingList()
    {

        if (Settings.value == 1)
        {
            audioSource.clip = walk;
            audioSource.Stop();
        }
        else if (Settings.value == 2)
        {
            audioSource.clip = walk;
            audioSource.Play();

        }
    }
}
