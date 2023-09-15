using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //for movement
    private float movementSpeed = 7.0f;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    //for getting mouse direction
    private float turnSpeed = 10f;
    //for camara follow
    public Camera cam;
    //for keycard
    public GameObject keycard;
    public bool hasKeycard = false;
    //for donut
    public GameObject donut;
    public bool hasDonut = false;
    //for boss
    public GameObject boss;
    public bool hitBoss = false;
    //for sounds
    public AudioClip deathSound;
    public AudioClip keyPickup;
    public AudioClip winSound;
    public AudioSource playerSound;
    public AudioSource bossSound;

    void Update()
    {
        ProcessInputs();
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, -5);

    }
    void FixedUpdate()
    {
        Move();
        
    }
    void ProcessInputs()
    {
        //moving sprite
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

        //changing direction
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, turnSpeed * Time.deltaTime);
    }
    private void Move()
    {
        //move sprite
        rb.velocity = new Vector2(moveDirection.x * movementSpeed, moveDirection.y * movementSpeed);
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.gameObject.name == "Keycard")
        {
            Destroy(keycard);
            hasKeycard = true;
            //playerSound.PlayOneShot(keyPickup, 1f);
            AudioSource.PlayClipAtPoint(keyPickup, 0.9f * Camera.main.transform.position + 0.1f * transform.position, 20f);
        }

        if(collision.transform.gameObject.name == "Donut")
        {
            Destroy(donut);
            hasDonut = true;
            AudioSource.PlayClipAtPoint(winSound, 0.9f * Camera.main.transform.position + 0.1f * transform.position, 5f);

        }

        if(collision.transform.gameObject.name == "Boss")
        {
            AudioSource.PlayClipAtPoint(deathSound, 0.9f * Camera.main.transform.position + 0.1f * transform.position, 20f);
            Destroy(this.gameObject);
            hitBoss = true;

        }




    }


}
