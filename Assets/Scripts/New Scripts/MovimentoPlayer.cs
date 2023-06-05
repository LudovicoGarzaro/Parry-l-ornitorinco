using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovimentoPlayer : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    public float defaultTime = 2f;
    public float time;

    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity;

    public Transform player;
    public Vector3 rotateAmount;
    public bool isStop;
    public bool isParrying;
    public GameObject codacollider;

    public float defaultColdown = 3f;
    public float coldown;
    bool isOnColdown = false;
    bool coldownActive = false;


    private void Awake()
    {
        characterController = GetComponent < CharacterController>();
    }

    public void Start()
    {
        isStop = true;


        codacollider.SetActive(false);

    }

    private void Update()
    {
        bool parry = Input.GetKeyDown(KeyCode.Space);

        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        if (characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * rotationSpeed * hInput;

            

        }
        
        if(hInput == 0 && vInput == 0)
        {

            isStop = true;

        }
        else
        {
            

            isStop = false;

            isParrying = false;

            time = defaultTime;

            codacollider.SetActive(false);

        }

    
        

        if (parry && isStop == true && coldownActive == false)
        {
            isParrying = true;
            coldownActive = true;
        }

        if (isStop == true && time > 0f && isParrying == true)
        {
            player.Rotate(rotateAmount * Time.deltaTime);
            time -= Time.deltaTime;
            codacollider.SetActive(true);

        }

        if (time < 0f)
        {
            isParrying = false;
            time = defaultTime;
            codacollider.SetActive(false);
            isOnColdown = true;
        }

        if (isOnColdown)
        {

            
            coldown -= Time.deltaTime;

            
            

            if(coldown <= 0f)
            {
                isOnColdown = false;
                coldown = defaultColdown;
                coldownActive = false;
            }
        }

        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);

    }
}
