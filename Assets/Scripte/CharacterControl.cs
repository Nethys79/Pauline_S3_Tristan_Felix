using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public int Helper;


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
        ZenitaleMode.SetActive(false);

        RuelleMode = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode");
        RuelleMode.SetActive(false);

        Helper = 0;
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
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, LookAxis.x * lookSpeed, 0);
        }

        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range));
        {
            if(hit.transform.gameObject.layer == LayerMask.NameToLayer("Interactible") && hit.distance < 2)
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
                Helper = 0;
            }
        }

        
    }

    public void InteracteIn()
    {
        Debug.Log("Je clique");
        if(Helper == 1)
        {
            FpsMode.SetActive(false);
            ZenitaleMode.SetActive(true);
        }
        if (Helper == 2)
        {
            FpsMode.SetActive(false);
            RuelleMode.SetActive(true);
        }
    }
    
    public void InteracteOut()
    {
        Debug.Log("Je clique");
        FpsMode.SetActive(true);
        ZenitaleMode.SetActive(false);
        RuelleMode.SetActive(false);
    }
}
