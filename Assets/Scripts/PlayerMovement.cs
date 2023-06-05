using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    
    public Transform cam;

    public float speed = 6f;
   
    public float defaultTime = 2f;
    public float time;
    private CharacterController controller;

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

    Vector3 velocity;
    public float gravity = -20f;

    public void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    public void Start()
    {
        isStop = true;

        coldown = defaultColdown;

        codacollider.SetActive(false);
        
    }

                 

    void Update()
    {
        

        

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (controller.isGrounded)
        {
            velocity.y = 0f;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);

        }
        
        

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;           
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            isStop = false;

            isParrying = false;

            time = defaultTime;

            codacollider.SetActive(false);

            coldownActive = false;
        }
        else
        {
            isStop = true;
            
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isStop == true && coldownActive == false)
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

        if(time < 0f)
        {
            isParrying = false;
            time = defaultTime;
            codacollider.SetActive(false);
            isOnColdown = true;
        }

        if (isOnColdown)
        {
            coldown -= Time.deltaTime;

            if (coldown <= 0)
            {
                isOnColdown = false;
                coldown = defaultColdown;
                coldownActive = false;
            }


        }

       
        
        
        
    }

   



    
}


