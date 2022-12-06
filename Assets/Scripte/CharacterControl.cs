using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    [Header("------Déplacement------")]
    public float walkingSpeed = 7.5f;
    public float runningSpeed = 11.5f;
    public float gravity = 20.0f;

    [Header("------Regard------")]
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;


    [Header("------Raycast && Interaction------")]
    [Tooltip("Longueur du raycast. Est définie dans le Void Start")]
    public float range;

    [SerializeField]
    private GameObject dot;
    private Image dotImage;

    [SerializeField]
    private GameObject InteractionButton;
    private Image InteractionButtonImage;

    [SerializeField]
    private GameObject FpsMode;
    [SerializeField]
    private GameObject ZenitaleMode;
    [SerializeField]
    private GameObject RuelleMode;
    [SerializeField]
    private GameObject PauseMode;

    [Header("------Position Camera------")]
    [SerializeField]
    private int Helper;

    private bool ViewIsChanged;

    [SerializeField]
    private GameObject VueFPS;

    [SerializeField]
    private GameObject VueRuelle;
    private GameObject RuelleBackButton;

    [SerializeField]
    private GameObject VueBureau;
    private GameObject BureauBackButton;
    private GameObject BureauBookPanel;
    private GameObject TEST1;
    private GameObject TEST2;
    private GameObject BureauBookBackButton;

    
    private GameObject PauseModeBackButton;


    [HideInInspector]
    public Vector2 RunAxis;
    [HideInInspector]
    public Vector2 LookAxis;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    [HideInInspector]
    public bool canMove = true;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        range = 10;

        dot = GameObject.Find("/-----UI-----/Canvas/FPS Mode/Dot");
        dotImage = dot.GetComponent<Image>();

        InteractionButton = GameObject.Find("/-----UI-----/Canvas/FPS Mode/ActivateInteraction");
        InteractionButtonImage = InteractionButton.GetComponent<Image>();
        InteractionButton.SetActive(false);

        FpsMode = GameObject.Find("/-----UI-----/Canvas/FPS Mode");
        FpsMode.SetActive(true);

        ZenitaleMode = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode");
        BureauBackButton = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/BackButton");
        BureauBookPanel = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel");
        TEST1 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/TEST1");
        TEST2 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/TEST2");
        BureauBookBackButton = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/BackButton");

        ZenitaleMode.SetActive(false);
        BureauBookPanel.SetActive(false);
        TEST1.SetActive(false);
        TEST2.SetActive(false);
        BureauBookBackButton.SetActive(false);

        RuelleMode = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode");
        RuelleBackButton = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/BackButton");
        RuelleMode.SetActive(false);

        PauseMode = GameObject.Find("/-----UI-----/Canvas/Pause");
        PauseModeBackButton = GameObject.Find("/-----UI-----/Canvas/Pause/BackButton");
        PauseMode.SetActive(false);

        VueFPS = GameObject.Find("/-----Player-----/CamPos1");

        VueRuelle = GameObject.Find("/-----ENVIRONNEMENT-----/RuelleBox/CamPos2");

        VueBureau = GameObject.Find("/-----ENVIRONNEMENT-----/CamPos3");

        Helper = 0;

        ViewIsChanged = false;


        playerCamera.fieldOfView = 70;
    }

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * RunAxis.y : 0;
        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * RunAxis.x : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);
        moveDirection.y = movementDirectionY;

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }


        characterController.Move(moveDirection * Time.deltaTime);


        if (canMove)
        {
            rotationX += -LookAxis.y * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);

            if (!ViewIsChanged)
            {
                playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
                transform.rotation *= Quaternion.Euler(0, LookAxis.x * lookSpeed, 0);
            }
        }

        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range)) ;
        {
            if (!ViewIsChanged)
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Interactible") && hit.distance < 2)
                {


                    dotImage.color = new Color(dotImage.color.r, dotImage.color.g, dotImage.color.b, 1);

                    InteractionButton.SetActive(true);
                    InteractionButtonImage.color = new Color(InteractionButtonImage.color.r, InteractionButtonImage.color.g, InteractionButtonImage.color.b, 1);

                    if (hit.transform.tag == "Table")
                    {
                        Debug.Log("active table");
                        Helper = 1;
                    }

                    if (hit.transform.tag == "Window")
                    {
                        Debug.Log("active window");
                        Helper = 2;
                    }
                }
                else
                {
                    dotImage.color = new Color(dotImage.color.r, dotImage.color.g, dotImage.color.b, 0);

                    InteractionButton.SetActive(false);
                    InteractionButtonImage.color = new Color(InteractionButtonImage.color.r, InteractionButtonImage.color.g, InteractionButtonImage.color.b, 0);
                }
            }
        }

        if (ViewIsChanged)
        {
            Debug.DrawRay(playerCamera.ScreenPointToRay(Input.mousePosition).origin, playerCamera.ScreenPointToRay(Input.mousePosition).direction, Color.red);
            if (Physics.Raycast(playerCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.transform.tag == "1")
                {
                    BureauBookPanel.SetActive(true);
                    BureauBookBackButton.SetActive(true);
                    TEST1.SetActive(true);
                    Debug.Log(hit.transform.name);
                }

                if (hit.transform.tag == "2")
                {
                    BureauBookPanel.SetActive(true);
                    BureauBookBackButton.SetActive(true);
                    TEST2.SetActive(true);
                    Debug.Log(hit.transform.name);
                }
            }
        }
    }

    public void InteracteIn()
    {
        Debug.Log("Je clique");
        if (Helper == 1)
        {
            canMove = false;
            playerCamera.fieldOfView = 70;
            ViewIsChanged = true;
            FpsMode.SetActive(false);
            ZenitaleMode.SetActive(true);
            playerCamera.transform.position = VueBureau.transform.position;
            playerCamera.transform.rotation = VueBureau.transform.rotation;
        }
        if (Helper == 2)
        {
            ViewIsChanged = true;
            FpsMode.SetActive(false);
            RuelleMode.SetActive(true);
            playerCamera.transform.position = VueRuelle.transform.position;
            playerCamera.transform.rotation = VueRuelle.transform.rotation;
        }
    }

    public void InteracteOut()
    {
        canMove = true;
        playerCamera.fieldOfView = 70;
        ViewIsChanged = false;
        Helper = 0;
        Debug.Log("Je clique");
        FpsMode.SetActive(true);
        ZenitaleMode.SetActive(false);
        RuelleMode.SetActive(false);
        playerCamera.transform.position = VueFPS.transform.position;
        playerCamera.transform.rotation = VueFPS.transform.rotation;
    }

    public void BookInteracteOut()
    {
        BureauBookPanel.SetActive(false);
        BureauBookBackButton.SetActive(false);
        TEST2.SetActive(false);
    }

    public void Pause()
    {
        PauseMode.SetActive(true);
    }
    
    public void QuitPause()
    {
        PauseMode.SetActive(false);
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(sceneName: "Menu");
    }
    
    public void Option()
    {
        Debug.Log("OptionButton");
    }
}
