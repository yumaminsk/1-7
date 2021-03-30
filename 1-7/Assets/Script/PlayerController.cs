using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Gravity = -9.81f;
    public float Speed = 10.0f;
    public CharacterController controller;
    public float jumpHeight = 2.0f;
    Vector3 velocity;
    public Vector3 movement;
    bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isMoving = false;
    public AudioSource Audio;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        movement = transform.right * z + transform.forward * x;
        controller.Move(movement * Speed * Time.deltaTime);

        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (x != 0 || z != 0) { isMoving = true; }
        else { isMoving = false; }
        Steps();
    }
    void Steps()
    {
        if (isMoving == true && Audio.isPlaying == false)
        {
            StartCoroutine(StepVoice());
            IEnumerator StepVoice()
            {
                Audio.volume = Random.Range(0.8f, 1);
                Audio.pitch = Random.Range(1.2f, 1.8f);
                Audio.Play();
                yield return new WaitForSeconds(0.5f);
                Audio.Stop();
            }
        }
    }
}
