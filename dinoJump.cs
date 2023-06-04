using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoJump : MonoBehaviour
{
 public float speed = 5f;
    public float jumpSpeed = 8f;
    private float direction = 0f;
    private Rigidbody2D player;
    private Animator anim;
    Vector3 boundary;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        boundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
     
        player.velocity = new Vector2(direction * speed, player.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, 14f);
        }

        if (direction > 0f)
        {
            anim.SetBool("isJump", true);
        }
        else if (direction < 0f)
        {
            anim.SetBool("isJump", true);
        }
        else
        {
            anim.SetBool("isJump", false);
        }


        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else
        {
            //player.velocity = new Vector2(0, player.velocity.y);
            player.velocity = new Vector2(0, player.velocity.y);
        }

        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
    }
}
