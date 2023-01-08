using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptedJourney : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject LetterBox;
    [SerializeField]
    public GameObject ClosedDoor;
    [SerializeField]
    public GameObject LetterUI;
    [SerializeField]
    public GameObject IntroUI;
    [SerializeField]
    private GameObject dialogueBox1;
    private BoxCollider dialogueBoxCollider1;

    [SerializeField]
    private GameObject endBox;

    [SerializeField]
    public int StatusTuto;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("/-----Player-----");
        Player.transform.position = new Vector3(-1, 1, 1);

        LetterBox = GameObject.Find("/-----Scripted journey-----/LetterBox");
        LetterBox.SetActive(false);
        
        dialogueBox1 = GameObject.Find("/-----Scripted journey-----/DialogueBox1");
        dialogueBox1.SetActive(false);

        endBox = GameObject.Find("/-----Scripted journey-----/End");
        endBox.SetActive(false);

        ClosedDoor = GameObject.Find("/-----ENVIRONNEMENT-----/PorteClosed");
        ClosedDoor.SetActive(true);

        LetterUI = GameObject.Find("/-----UI-----/Canvas/PanelLetter");
        LetterUI.SetActive(false);

        IntroUI = GameObject.Find("/-----UI-----/Canvas/Intro");
        IntroUI.SetActive(true);



        StatusTuto = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (StatusTuto == 0)
        {
            LetterBox.SetActive(true);
        }
        
        if (StatusTuto == 1)
        {
            LetterBox.SetActive(false);
            ClosedDoor.SetActive(false);
            dialogueBox1.SetActive(true);
        }

        if (StatusTuto == 2)
        {
            dialogueBox1.SetActive(false);
        }

        if (StatusTuto == 10)
        {
            endBox.SetActive(true);
        }
    }
}
