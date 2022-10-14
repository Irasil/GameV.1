using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    
    public float speed = 12f;
    public float gravity = -9.81f;
    public float gravityMultiplier = 1f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;
    private float ySpeed;
    public float jumpHeight = 6.5f;
    public float speed1 = 2.0f;
    public int health;
    public GameObject DeadUi;

    private Animator animator;
    public GameObject wald;
    public GameObject magazin;

    private void Start()
    {
           animator = GetComponent<Animator>();
           
    }



    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y <0)
        {
            velocity.y = -1f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move.normalized* speed * Time.deltaTime);
        animator.SetFloat("Speed", move.normalized.magnitude *2);
        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && gameObject.transform.position.y < 1f)       
        {
            velocity.y = jumpHeight;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            wald.SetActive(false);
            magazin.SetActive(false);
            DeadUi.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Destroy(gameObject);
        }
    }
}
