using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float defaultTime = 2f;
    public float time;

    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity;

    public Transform player;
    public Vector3 rotateAmount;
    public bool isStop;
    public bool isParrying;
    public GameObject codacollider;
    public AudioSource parryaudio;
    
    

    public void Start()
    {
        isStop = true;


        codacollider.SetActive(false);
        
    }

                 

    void Update()
    {
        bool parry = Input.GetKeyDown(KeyCode.Space);

        

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        

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
        }
        else
        {
            isStop = true;
            
        }

        if (parry && isStop == true)
        {
            isParrying = true;

            parryaudio.Play();
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
        }
    }

   



    
}


