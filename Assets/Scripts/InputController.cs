using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public static InputController Instance;
    Player MyPlayer;

    public Player myPlayer { get ; set ; }

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GameObject.Find("Player").GetComponent<Player>();

    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            PlayerController.Instance.Jump();
        else if  (Input.GetKeyDown(KeyCode.DownArrow))
                PlayerController.Instance.Crawl();
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            PlayerController.Instance.MoveRight();
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            PlayerController.Instance.MoveLeft();
    }
}